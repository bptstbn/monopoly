using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Tax: Square, ISquare
    {
        public double Amount {
            get; private set;
        }

        public Tax(int position, string name, double amount) : base(position, name)
        {
            this.Amount = amount;
        }

        public override void ActionOnPlayer(Player player)
        {
            player.Money -= this.Amount;
        }
    }
}
