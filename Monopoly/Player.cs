using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Player
    {
        protected IStatePlayer state;
        protected string name;
        protected int token;
        protected double money;
        protected int position;
        protected int countDouble;
        protected int countTurnJail;


        public Player(double money)
        {
            this.money = money;
        }

        public void Action()
        {
            state.Action(this);
        }

        public bool IsImprisoned()
        {
            return state.IsImprisoned(this);
        }

        #region Propriétés 
        public double Money {
            get => money;
            set => money = value;

        }

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public IStatePlayer State {
            get {
                return state;
            }
            set {
                state = value;
            }
        }

        public int Token {
            get {
                return token;
            }
            set {
                token = value;
            }
        }

        public int Position {
            get {
                return position;
            }
            set {
                position = value;
            }
        }

        public int CountDouble {
            get {
                return countDouble;
            }
            set {
                countDouble = value;
            }
        }

        public int CountTurnJail {
            get {
                return countTurnJail;
            }
            set {
                countTurnJail = value;
            }
        }



        #endregion


    }
}
