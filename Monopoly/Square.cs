using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Square
    {
        protected string name;

        public Square(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public virtual void Action(Player player, Dice dice)
        {
            // depends on each type of square
        }
    }
}