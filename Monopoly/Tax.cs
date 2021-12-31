using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Tax: Square, ISquare
    {
<<<<<<< HEAD
        private double amount;

        public double Amount {
            get => amount;
            //set => amount = value;
=======
        public double Amount {
            get; private set;
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
        }

        public Tax(int position, string name, double amount) : base(position, name)
        {
<<<<<<< HEAD
            this.amount = amount;
=======
            this.Amount = amount;
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
        }

        public override void ActionOnPlayer(Player player)
        {
<<<<<<< HEAD
            player.Money -= amount;
=======
            player.Money -= this.Amount;
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
        }
    }
}
