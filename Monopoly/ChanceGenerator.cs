using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public static class ChanceGenerator
    {
        //public static void BankIsGivingYouMoney(Player player)
        //{
        //    player.Money += 100;
        //    Console.WriteLine("The Bank is giving you 100$.");
        //}

        //public static void GoodPilot(Player player)
        //{
        //    player.Money += 50;
        //    Console.WriteLine("You won a rallye, take your 50$.");
        //}

        public static void AdvanceToBoardwalk(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Chance Card : advance to Boardwalk");
            player.Position = 39;
            game.Board.Array[player.Position].Action(player, dice, game);

        }

        public static void AdvanceToGo(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Chance Card : advance to Go, and collect 200$");
            player.Position = 0;
            player.Money += 200;
            //game.Board.Array[player.Position].Action(player, dice, game);
        }

        public static void AdvanceToIllinois(Player player, Dice dice, Game game)
        {
            if (player.Position < 24) {
                Console.WriteLine("Chance Card : advance to Illinois Avenue");
                player.Position = 24;
                game.Board.Array[player.Position].Action(player, dice, game);
            }
            else {
                Console.WriteLine("Chance Card : advance to Illinois Avenue and collect 200$ (you pass Go");
                player.Position = 24;
                player.Money += 200;
                game.Board.Array[player.Position].Action(player, dice, game);
            }
        }

        public static void AdvanceToStCharlesPlace(Player player, Dice dice, Game game)
        {
            if (player.Position < 11) {
                Console.WriteLine("Chance Card : advance to St. Charles Place");
                player.Position = 11;
                game.Board.Array[player.Position].Action(player, dice, game);
            }
            else {
                Console.WriteLine("Chance Card : advance to St. Charles Place and collect 200$ (you pass Go");
                player.Position = 11;
                player.Money += 200;
                game.Board.Array[player.Position].Action(player, dice, game);
            }
        }

        public static void AdvanceToNearestRailroad(Player player, Dice dice, Game game)
        {
            if (player.Position == 7) {
                Console.WriteLine("Chance Card : advance to {0}", game.Board.Array[15].Name);
                player.Position = 15;
                game.Board.Array[player.Position].Action(player, dice, game);
            }
            else if (player.Position == 22) {
                Console.WriteLine("Chance Card : advance to {0}", game.Board.Array[25].Name);
                player.Position = 25;
                game.Board.Array[player.Position].Action(player, dice, game);
            }
            else {
                //else if (player.Position == 36)
                Console.WriteLine("Chance Card : advance to {0}", game.Board.Array[5].Name);
                player.Position = 5;
                player.Money += 200;
                game.Board.Array[player.Position].Action(player, dice, game);
            }
        }


        public static void BankPaysDivident(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Chance Card : bank pays you dividend of $50, {0}", player.Name);
            player.Money += 50;
        }

        //public static void GetOutOfJailFree(Player player, Dice dice, Game game)
        //{
        //    //A recheck
        //    Console.WriteLine("Chance Card : get Out of Jail Free, {0}", player.Name);
        //    player.State = new Free();
        //    player.Action();
        //}

        public static void GoBack3Spaces(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Chance Card : go Back 3 Spaces, {0}", player.Name);
            player.Position -= 3;
            game.Board.Array[player.Position].Action(player, dice, game);
        }

        public static void GoToJail(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Chance Card : go directly to Jail, do not pass Go, do not collect $200, {0}", player.Name);
            player.PutInJail();
        }

        public static void GeneralRepairs(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Chance Card : {0}, make general repairs on all your property. For each property pay $25.", player.Name);
            int countProperty = 0;
            foreach(Asset asset in player.Assets) {
                if (asset is Property) {
                    countProperty += 1;
                }
            }
            player.Money -= 25 * countProperty;
            FreeParking.amount2 += 25 * countProperty;
        }

        public static void SpeedingFine(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Chance Card : speeding fine $15, {0}", player.Name);
            player.Money -= 15;
            FreeParking.amount2 += 15;
        }

        public static void TripToReadingRailroad(Player player, Dice dice, Game game)
        {
            if (player.Position < 5) {
                Console.WriteLine("Chance Card : take a trip to Reading Railroad.");
                player.Position = 5;
                game.Board.Array[player.Position].Action(player, dice, game);
            }
            else {
                Console.WriteLine("Chance Card : take a trip to Reading Railroad. If you pass Go, collect $200");
                player.Position = 5;
                player.Money += 200;
                game.Board.Array[player.Position].Action(player, dice, game);
            }
        }

        public static void ElectedChairman(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Chance Card : {0}, you have been elected Chairman of the Board. Pay each player $50", player.Name);
            foreach (Player otherPlayer in game.Players) {
                otherPlayer.Money += 50;
                player.Money -= 50;
            }
        }

        public static void BuildingLoanMatures(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Chance Card : {0}, your building loan matures. Collect $150", player.Name);
            player.Money += 150;
        }





        public static void RandomCard(Player player, Dice dice, Game game)
        {
            Random rd = new Random();
            int rdCard = rd.Next(1, 15);

            if (rdCard == 1) {
                BuildingLoanMatures(player, dice, game);
            }
            else if (rdCard == 2) {
                AdvanceToBoardwalk(player, dice, game);
            }
            else if (rdCard == 3) {
                AdvanceToGo(player, dice, game);
            }
            else if (rdCard == 4) {
                AdvanceToIllinois(player, dice, game);
            }
            else if (rdCard == 5) {
                AdvanceToStCharlesPlace(player, dice, game);
            }
            else if (rdCard == 6) {
                AdvanceToNearestRailroad(player, dice, game);
            }
            else if (rdCard == 7) {
                BankPaysDivident(player, dice, game);
            }
            else if (rdCard == 8) {
                //GetOutOfJailFree(player, dice, game);
            }
            else if (rdCard == 9) {
                GoBack3Spaces(player, dice, game);
            }
            else if (rdCard == 10) {
                GoToJail(player, dice, game);
            }
            else if (rdCard == 11) {
                GeneralRepairs(player, dice, game);
            }
            else if (rdCard == 12) {
                SpeedingFine(player, dice, game);
            }
            else if (rdCard == 13) {
                TripToReadingRailroad(player, dice, game);
            }
            else{
                ElectedChairman(player, dice, game);
            }

        }
    }
}
