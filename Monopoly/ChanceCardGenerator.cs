using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public static class ChanceCardGenerator
    {
        public static void BankIsGivingYouMoney(Player player)
        {
            player.Money += 100;
            Console.WriteLine("The Bank is giving you 100$.");
        }

        public static void GoodPilot(Player player)
        {
            player.Money += 50;
            Console.WriteLine("You won a rallye, take your 50$.");
        }


        public static void RandomCard(Player player)
        {
            Random rd = new Random();
            int rdCard = rd.Next(1, 3);
            if (rdCard == 1) {
                BankIsGivingYouMoney(player);
            }
            else {
                GoodPilot(player);
            }
        }
    }
}
