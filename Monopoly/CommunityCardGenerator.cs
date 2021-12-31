using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public static class CommunityCardGenerator
    {
<<<<<<< HEAD

=======
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
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
