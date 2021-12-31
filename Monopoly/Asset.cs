using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public abstract class Asset: Square, ISquare
    {
<<<<<<< HEAD
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
=======
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
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
        }

        public Asset(int position, string name, int price, double mortgageValue, int rent, Player owner = null) :base(position, name)
        {
<<<<<<< HEAD
            this.price = price;
            this.mortgageValue = mortgageValue;
            this.owner = owner;
            this.rent = rent;
=======
            this.Price = price;
            this.MortgageValue = mortgageValue;
            this.Owner = owner;
            this.Rent = rent;
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
        }

        public override void ActionOnPlayer(Player player)
        {
<<<<<<< HEAD

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
=======
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
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
            }

        }




    }
}
