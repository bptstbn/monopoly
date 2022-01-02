using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Tax : Square
    {
        private double amount;

        public Tax(string name, double amount) : base(name)
        {
            this.amount = amount;
        }
        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }

        public override void Action(Player player, Dice dice, Game game)
        {
            if (this.amount > player.Money)
            {
                player.Bankrupt();
            }
            else
            {                
                player.Money -= this.amount;
                Console.WriteLine("You have just paid {0}$, you have {1}$ left.", this.amount, player.Money);
            }
        }
    }
}
