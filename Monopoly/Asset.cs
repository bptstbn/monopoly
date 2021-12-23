using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public abstract class Asset: Square, ISquare
    {
        public int Price {
            get; private set;
        }
        public double MortgageValue {
            get; set;
        }
        public Player Owner {
            get; set;
        }

        public int Rent {
            get; private set;
        }

        public Asset(int position, string name, int price, double mortgageValue, int rent, Player owner = null) :base(position, name)
        {
            this.Price = price;
            this.MortgageValue = mortgageValue;
            this.Owner = owner;
            this.Rent = rent;
        }

        public override void ActionOnPlayer(Player player)
        {
            if (this.Owner == player) {
                Console.WriteLine("You own this already.");
            }
            else if (this.Owner == null) {
                Console.WriteLine(this.Name + " is available for purchase.");
            }
            else {
                player.Money -= this.Rent;
                this.Owner.Money += this.Rent;
                Console.WriteLine("You've lost " + this.Rent + "$.");
            }

        }




    }
}
