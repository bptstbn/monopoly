using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Free : IStatePlayer
    {
        public void Action(Player context)
        {
            // nothing to do (player is now free)
        }

        public bool IsImprisoned(Player context)
        {
            return false;
        }
    }
}