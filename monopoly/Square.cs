using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    abstract public class Square
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
        public virtual void Action(Player player, Dice dice, Game game)
        {
            // depends on each type of square
        }
    }
}