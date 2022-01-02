using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Imprisoned : IStatePlayer
    {
        public void Action(Player context)
        {
            // put player in jail
            // ie. player.position = 10
        }

        public bool IsImprisoned(Player context)
        {
            return true;
        }
    }
}