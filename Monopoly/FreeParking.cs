using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class FreeParking : Square
    {
        private double amount;

        public FreeParking() : base("Free Parking")
        {
            this.amount = 0;
        }

        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }

        public override void Action(Player player, Dice dice)
        {
            if (this.amount == 0)
            {
                Console.WriteLine("Unfortunately, there is no money to be collected at the moment.");
            }
            else
            {
                player.Money += this.amount;
                Console.WriteLine("Congratulations, you have just won {0}", this.amount);
                this.amount = 0;
            }
        }
    }
}