using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    public class Player
    {
        protected string name;
        protected int token;
        protected bool free;
        protected int position;
        protected double money;
        protected int countDouble;
        protected int countTurnJail;
        protected List<Asset> assets;
        protected bool eliminated;

        public Player(string name)
        {
            this.name = name;
            this.token = 0;
            this.free = true;
            this.position = 0;
            this.money = 1500;
            this.countDouble = 0;
            this.countTurnJail = 0;
            this.assets = new List<Asset>();
            this.eliminated = false;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Token
        {
            get { return this.token; }
            set { this.token = value; }
        }

        public bool Free
        {
            get { return this.free; }
            set { this.free = value; }
        }

        public int Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
        public double Money
        {
            get { return this.money; }
            set { this.money = value; }
        }

        public int CountDouble
        {
            get { return this.countDouble; }
            set { this.countDouble = value; }
        }

        public int CountTurnJail
        {
            get { return this.countTurnJail; }
            set { this.countTurnJail = value; }
        }

        public List<Asset> Assets
        {
            get { return this.assets; }
            set { this.assets = value; }
        }

        public bool Eliminated
        {
            get { return this.eliminated; }
            set { this.eliminated = value; }
        }

        public void PutInJail()
        {
            this.free = false;
            Console.WriteLine("You are going to jail...");
            this.Position = 10;
        }

        public void RealeaseFromJail()
        {
            this.CountTurnJail = 0;
            Console.WriteLine("Congratulations, you are now free and can move again ! ");
        }

        public bool Replay(Dice dice)
        {
            if (dice.IsDouble())
            {
                this.countDouble += 1;
                Console.WriteLine("You can play again !");
                if (!TooManyDoubles() && this.free)
                {
                    if (countDouble == 2)
                    {
                        Console.WriteLine("Be careful, if you roll doubles again, you will go to jail.");
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool TooManyDoubles()
        {
            if (this.countDouble == 3)
            {
                Console.WriteLine("You have rolled three doubles in a row, thus you are going to jail.");
                this.PutInJail();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EndTurn(Dice dice)
        {
            if (!Replay(dice))
            {
                this.countDouble = 0;
                return true;
            }
            if (countTurnJail > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Bankrupt(double amountToPay)
        {
            Console.WriteLine("You went bankrupt.");
            while (this.money < amountToPay && !this.eliminated)
            {
                if (this.assets.Count == 0)
                {
                    Console.WriteLine("You don't have any assets to mortgage so you are eliminated.");
                    this.eliminated = true;
                }
                else
                {
                    Console.WriteLine("You have to pay {0} but you are {0}$ short.", amountToPay, amountToPay - this.money);
                    Console.WriteLine("You own the following asset(s) : ");
                    foreach (Asset asset in this.assets)
                    {
                        Console.WriteLine("Name : {0} // Mortgage value : {1}", asset.Name, asset.MortgageValue());
                    }
                    List<string> names = new List<string>();
                    foreach (Asset asset in this.assets)
                    {
                        names.Add(asset.Name);
                    }
                    bool valid = false;
                    string input = "";
                    do
                    {
                        Console.WriteLine("Which one do you want to mortgage ?");
                        try
                        {
                            input = Console.ReadLine();
                        }
                        catch (FormatException) { }
                        if (!names.Contains(input))
                        {
                            valid = false;
                            Console.WriteLine("Your input isn't valid, try again !\n");
                        }
                        else
                        {
                            valid = true;
                        }
                    } while (!valid);

                    money += assets.Find(a => a.Name == input).MortgageValue();
                    assets.Find(a => a.Name == input).Owner = null;
                    assets.RemoveAll(a => a.Name == input);
                }
            }
        }

        public void MoveForward(Dice dice)
        {
            if (!this.free)
            {
                if (dice.IsDouble())
                {
                    Console.WriteLine("You rolled doubles !");
                    this.free = true;
                    this.RealeaseFromJail();
                    MoveForward(dice);
                }
                else if (countTurnJail > 2)
                {
                    Console.WriteLine("You spent 3 turns in jail. You made your time.");
                    this.free = true;
                    this.RealeaseFromJail();
                    MoveForward(dice);
                }
                else
                {
                    Console.WriteLine("You can't move, you are still in jail.");
                }
            }
            else
            {
                if (this.position + dice.Sum() > 39)
                {
                    this.money += 200;
                    Console.WriteLine("You have just collected 200$ as you passed by the Go square. You now have {0}$.", this.money);
                }
                this.position = (this.position + dice.Sum()) % 40;
            }
        }
    }
}