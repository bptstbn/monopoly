using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public static class CommunityChestGenerator
    {
   
        //public static void PayHospitalFees(Player player)
        //{
        //    player.Money -= 100;
        //    Console.WriteLine("You need to pay 100$ for hospital fees");
        //}


        public static void AdvanceToGo(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : advance to Go, and collect 200$.");
            player.Position = 0;
            player.Money += 200;
            //game.Board.Array[player.Position].Action(player, dice, game);
        }

        public static void BankErrorInYourFavor(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : error of the bank in your favor {0}, you win 200$.", player.Name);
            player.Money += 200;
            
        }

        public static void DoctorFee(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : doctor’s fee. Pay $50.");
            player.Money -= 50;
            FreeParking.amount2 += 50;
        }

        public static void SaleOfStock(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : {0}, from sale of stock you get $50.", player.Name);
            player.Money += 50;
        }

        //public static void GetOutOfJailFree(Player player, Dice dice, Game game)
        //{
        //    //A recheck
        //    Console.WriteLine("Community Chest card : get Out of Jail Free, {0}.", player.Name);
        //    player.State = new Free();
        //    player.Action();
        //}

        public static void GoToJail(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : go directly to Jail, do not pass Go, do not collect $200, {0}.", player.Name);
            player.PutInJail();
        }

        public static void HolidayFundMatures(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : holiday fund matures, {0}. Receive $100.", player.Name);
            player.Money += 100;
        }

        public static void IncomeTaxRefund(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : income tax refund, {0}. Receive $20.", player.Name);
            player.Money += 20;
        }

        public static void YourBirthday(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : it is your birthday {0}. Collect $10 from every player.", player.Name);
            foreach (Player otherPlayer in game.Players) {
                otherPlayer.Money -= 10;
                player.Money += 10;
            }
        }

        public static void LifeInsuranceMatures(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : life insurance matures, {0}. Receive $100.", player.Name);
            player.Money += 100;
        }

        public static void PayHospitalFees(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : {0}, pay hospital fees of $100.", player.Name);
            player.Money -= 100;
            FreeParking.amount2 += 100;
        }

        public static void PaySchoolFees(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : {0}, pay school fees of $50.", player.Name);
            player.Money -= 50;
            FreeParking.amount2 += 50;

        }

        public static void ConsultancyFee(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : {0}, receive $25 consultancy fee.", player.Name);
            player.Money += 25;
        }

        public static void StreetRepair(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : {0}, you are assessed for street repair. $40 per property.", player.Name);
            int countProperty = 0;
            foreach (Asset asset in player.Assets) {
                if (asset is Property) {
                    countProperty += 1;
                }
            }
            player.Money -= 40 * countProperty;
        }

        public static void BeautyContest(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : {0}, you have won second prize in a beauty contest. Collect $10.", player.Name);
            player.Money += 10;
        }

        public static void Inherit(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Community Chest card : {0}, you inherit $100.", player.Name);
            player.Money += 100;
        }




        public static void RandomCard(Player player, Dice dice, Game game)
        {
            Random rd = new Random();
            int rdCard = rd.Next(1, 17);

            if (rdCard == 1) {
                AdvanceToGo(player, dice, game);
            }
            else if (rdCard == 2) {
                BankErrorInYourFavor(player, dice, game);
            }
            else if (rdCard == 3) {
                DoctorFee(player, dice, game);
            }
            else if (rdCard == 4) {
                SaleOfStock(player, dice, game);
            }
            else if (rdCard == 5) {
                //GetOutOfJailFree(player, dice, game);
            }
            else if (rdCard == 6) {
                GoToJail(player, dice, game);
            }
            else if (rdCard == 7) {
                HolidayFundMatures(player, dice, game);
            }
            else if (rdCard == 8) {
                IncomeTaxRefund(player, dice, game);
            }
            else if (rdCard == 9) {
                YourBirthday(player, dice, game);
            }
            else if (rdCard == 10) {
                LifeInsuranceMatures(player, dice, game);
            }
            else if (rdCard == 11) {
                PayHospitalFees(player, dice, game);
            }
            else if (rdCard == 12) {
                PaySchoolFees(player, dice, game);
            }
            else if (rdCard == 13) {
                ConsultancyFee(player, dice, game);
            }
            else if (rdCard == 14) {
                StreetRepair(player, dice, game);
            }
            else if (rdCard == 15) {
                BeautyContest(player, dice, game);
            }
            else {
                Inherit(player, dice, game);
            }

        }





























    }
}
