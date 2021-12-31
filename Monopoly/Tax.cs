using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Tax: Square, ISquare
    {
        private double amount;

        public double Amount {
            get => amount;
            //set => amount = value;
        }

        public Tax(int position, string name, double amount) : base(position, name)
        {
            this.amount = amount;
        }

        public override void ActionOnPlayer(Player player)
        {
            player.Money -= amount;
        }
    }
}
