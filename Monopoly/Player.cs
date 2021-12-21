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
        protected float money;
        protected int position;
        protected int countDouble;
        protected int countTurnJail;

        public void Action()
        {
            state.Action(this);
        }

        public bool IsImprisoned()
        {
            return state.IsImprisoned(this);
        }
    }
}
