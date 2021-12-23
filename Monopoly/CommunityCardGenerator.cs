using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public static class CommunityCardGenerator
    {
        public static void BankErrorInYourFavor(Player player)
        {
            player.Money += 200;
            Console.WriteLine("Error of the bank, you win 200$");
        }

        public static void PayHospitalFees(Player player)
        {
            player.Money -= 100;
            Console.WriteLine("You need to pay 100$ for hospital fees");
        }

        public static void RandomCard(Player player)
        {
            Random rd = new Random();
            int rdCard = rd.Next(1, 3);
            if (rdCard == 1) {
                BankErrorInYourFavor(player);
            }
            else {
                PayHospitalFees(player);
            }
        }
    }
}
