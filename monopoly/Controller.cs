using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    public static class Controller
    {
        public static void PlayGame()
        {
            Game game = new Game();
            Console.WriteLine("\tWELCOME TO THE MONOPOLY GAME");
            View.DisplayBoard(game.Board, game.Players, 18);
            Initialize(game);
            do
            {
                PlayTurn(game);
            } while (game.Players.Count((player => !player.Eliminated)) != 1); // condition to stop the game
            Player winner = game.Players.Single(player => !player.Eliminated);
            Console.WriteLine("The game is over, the winner is {0}. Congrats.", winner.Name);
        }
        public static void Initialize(Game game)
        {
            bool valid = false;
            Console.WriteLine("\nHow many players will be playing ?");
            int nbplayers = -1;
            do
            {
                Console.Write("Please enter a number between 2 and 8 included : ");
                try
                {
                    nbplayers = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
                if (nbplayers < 2 || nbplayers > 8)
                {
                    valid = false;
                    Console.WriteLine("Your input isn't valid, try again !\n");
                }
                else
                {
                    valid = true;
                }
            } while (!valid);

            for (int i = 1; i <= nbplayers; i++)
            {
                Console.Write("Please enter the name of player n°{0} : ", i);
                string name = Console.ReadLine();
                Player player = new Player(name);
                game.Players.Add(player);
            }

            int k = 0;
            foreach (Player player in game.Players)
            {
                k += 1;
                player.Token = k;
                Console.WriteLine("Welcome {0}, you have been assigned token n°{1}", player.Name, player.Token);
            }
        }

        public static void PlayTurn(Game game)
        {
            foreach (Player player in game.Players)
            {
                if (!player.Eliminated)
                {
                    Console.WriteLine("\n\t\t{0}, it's your turn !", player.Name);
                    Console.WriteLine("\t\tYou have {0}$ on your account.", player.Money);
                    bool replay;
                    do
                    {
                        Console.WriteLine("Press any key to roll the dice : ");
                        Console.ReadKey();
                        Console.WriteLine();
                        Dice dice = new Dice();
                        dice.Roll();
                        player.MoveForward(dice);
                        View.DisplayBoard(game.Board, game.Players, 14);
                        View.DisplayDice(dice);
                        Console.WriteLine("You have landed on {0}.", game.Board.Array[player.Position].Name);
                        game.Board.Array[player.Position].Action(player, dice, game);
                        if (player.EndTurn(dice))
                        {
                            replay = false;
                        }
                        else
                        {
                            replay = true;
                        }
                    } while (replay && !player.Eliminated);

                    if (!player.Free)
                    {
                        player.CountTurnJail += 1;
                    }
                }
            }
        }
    }
}