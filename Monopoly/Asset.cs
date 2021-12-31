using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public abstract class Asset: Square, ISquare
    {
        protected int price;
        protected double mortgageValue;
        protected Player owner;
        public int rent;


        public int Price {
            get => price;
            //set => price = value;
        }
        public double MortgageValue {
            get => mortgageValue;
            //set => mortgageValue = value;
        }
        public Player Owner {
            get => owner;
            set => owner = value;
        }

        public int Rent {
            get => rent;
            set => rent = value;
        }

        public Asset(int position, string name, int price, double mortgageValue, int rent, Player owner = null) :base(position, name)
        {
            this.price = price;
            this.mortgageValue = mortgageValue;
            this.owner = owner;
            this.rent = rent;
        }

        public override void ActionOnPlayer(Player player)
        {

            if (owner == null) {
                Console.WriteLine(name + " is available for purchase.");
            }
            else if (owner == player) {
                Console.WriteLine("You own this already.");
            }
            else {
                player.Money -= rent;
                owner.Money += rent;
                Console.WriteLine("You've lost " + rent + "$.");
            }

        }




    }
}
