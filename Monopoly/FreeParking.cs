using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class FreeParking: Square, ISquare
    {
        private double availableCash;
        public double AvailableCash {
            get => availableCash;
            set => availableCash = value;
        }

        public FreeParking(int position, string name, double availableCash = 0) : base(position, name)
        {
            this.availableCash = availableCash;
        }

        public override void ActionOnPlayer(Player player)
        {

            if (availableCash == 0) {
                Console.WriteLine("No cash available");
            }
            else {
                player.Money += availableCash;
                availableCash = 0;
                Console.WriteLine(player.Name + " won " + availableCash + "$.");
            }

        }

    }
}
