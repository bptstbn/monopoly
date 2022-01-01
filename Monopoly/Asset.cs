using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public abstract class Asset : Square
    {
        protected double price;
        public Player owner;

        public Asset(string name, int price) : base(name)
        {
            this.price = price;
            this.owner = null;
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public double MortgageValue()
        {
            return this.price / 2;
        }

        public Player Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public virtual double Rent(Dice dice)
        {
            return 0;
        }

        public virtual ColorCategory ColorGroup()
        {
            return ColorCategory.None;
        }

        public void Buy(Player buyer)
        {
            this.owner = buyer;
            buyer.Money -= this.price;
            buyer.Assets.Add(this);
            Console.WriteLine("You now have {0}$.", buyer.Money);
            Console.WriteLine("{0} has been added to your assets.", this.name);
        }

        public void PayRent(Player client, Dice dice)
        {
            Console.WriteLine("You have just landed on a property owned by {0}; you owe him / her {1}$.", this.owner.Name, this.Rent(dice));
            if (this.Rent(dice) > client.Money)
            {
                Console.WriteLine("You went bankrupt");
                client.Bankrupt();
            }
            else
            {
                client.Money -= this.Rent(dice);
                this.owner.Money += this.Rent(dice);
                Console.WriteLine("You now have {0}$.", client.Money);
                Console.WriteLine("And {0} now has {1}$.", this.owner.Name, this.owner.Money);
            }
        }

        public override void Action(Player player, Dice dice)
        {
            if (this.owner == null)
            {
                if (this.price > player.Money)
                {
                    Console.WriteLine("Unfortunately, you can't afford this asset at the moment, you are {0}$ short.", this.price - player.Money);
                }
                else
                {
                    Console.WriteLine("Would you like to buy {0} for {1}$", this.name, this.price);
                    bool valid = false;
                    string input = "";
                    do
                    {
                        Console.WriteLine("\n(y / n)");
                        try
                        {
                            input = Console.ReadLine();
                        }
                        catch (FormatException) { }
                        if (input != "y" && input != "n")
                        {
                            valid = false;
                            Console.WriteLine("Your choice isn't valid, try again !\n");
                        }
                        else
                        {
                            valid = true;
                        }
                    } while (!valid);

                    switch (input)
                    {
                        case "y":
                            this.Buy(player);
                            break;
                        case "n":
                            Console.WriteLine("Alright, you have decided not to purchase this asset.");
                            break;
                        default:
                            Console.WriteLine("\nInvalid input => try again ...");
                            break;
                    }
                }
            }
            else
            {
                if (this.owner != player)
                {
                    this.PayRent(player, dice);
                }
                else 
                {
                    Console.WriteLine("This is your property !");
                }
            }
        }
    }
}