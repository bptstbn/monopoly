using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public interface IStatePlayer
    {
        public void Action(Player context);
        public bool IsImprisoned(Player context);
    }
}