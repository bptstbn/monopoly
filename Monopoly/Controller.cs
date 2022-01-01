using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public static class Controller
    {
        public static void Initialize(Game game)
        {
            bool valid = false;
            Console.WriteLine("\nHow many players will be playing ? ");
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
                    Console.WriteLine("Your choice isn't valid, try again !\n");
                }
                else
                {
                    valid = true;
                }
            } while (!valid);

            for (int i = 1; i <= nbplayers; i++)
            {
                Console.Write("Please enter the name of each player : ");
                string name = Console.ReadLine();
                Player player = new Player(name);
                game.Players.Add(player);
            }
            
            foreach (Player player in game.Players)
            {
                Console.WriteLine("Welcome " + player.Name);
            }
        }

        public static void PlayTurn(Game game)
        {
            foreach (Player player in game.Players)
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
                    View.DisplayDice(dice);
                    player.MoveForward(dice);
                    Console.WriteLine("You have landed on {0}.", game.Board.Array[player.Position].Name);
                    // View.DisplayBoard(game.Board);
                    game.Board.Array[player.Position].Action(player, dice);
                    if (player.EndTurn(dice))
                    {
                        replay = false;
                    }
                    else
                    {
                        replay = true;
                    }
                }while (replay);

                if (player.IsPrisoner())
                {
                    player.CountTurnJail += 1;
                }
            }
        }
    }
}
