using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class FreeParking: Square, ISquare
    {
        public double AvailableCash {
            get; set;
        }

        public FreeParking(int position, string name, double availableCash = 0) : base(position, name)
        {
            this.AvailableCash = availableCash;
        }

        public override void ActionOnPlayer(Player player)
        {
            if (this.AvailableCash == 0) {
                Console.WriteLine("No cash available");
            }
            else {
                player.Money += this.AvailableCash;
                this.AvailableCash = 0;
                Console.WriteLine(player.Name + " won " + this.AvailableCash + "$.");
            }

        }

    }
}
