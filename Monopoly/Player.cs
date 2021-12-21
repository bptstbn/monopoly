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

        public bool IsImprisoned()
        {
            return state.IsImprisoned(this);
        }
    }
}
