using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Player
    {
        protected string name;
        protected IStatePlayer state;
        protected int position;
        protected double money;
        protected int countDouble;
        protected int countTurnJail;
        protected List<Asset> assets;

        public Player(string name)
        {
            this.name = name;
            this.state = new Free();
            this.position = 0;
            this.money = 1500;
            this.countDouble = 0;
            this.countTurnJail = 0;
            this.assets = new List<Asset>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public IStatePlayer State
        {
            get { return this.state; }
            set { this.state = value; }
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

        public void Action()
        {
            state.Action(this);
        }

        public bool IsPrisoner()
        {
            return state.IsPrisoner(this);
        }

        public void PutInJail()
        {
            state = new Prisoner();
            Action();
        }

        public bool Replay(Dice dice)
        {
            if (dice.IsDouble())
            {
                this.countDouble += 1;
                Console.WriteLine("You can play again !");
                if (!TooManyDoubles() && !IsPrisoner())
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
                PutInJail();
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
        public void Bankrupt()
        {
            //the player went bankrupt : propose to mortgage his assets
            // if he has no assets eather he has lost

            // maybe add amount to pay as parameter to check that he has mortgaged enough
        }
        public void MoveForward(Dice dice)
        {
            if (IsPrisoner())
            {
                if (dice.IsDouble())
                {
                    Console.WriteLine("You rolled doubles !");
                    state = new Free();
                    Action();
                    MoveForward(dice);
                }
                else if (countTurnJail > 2)
                {
                    Console.WriteLine("You spent 3 turns in jail. You made your time.");
                    state = new Free();
                    Action();
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
