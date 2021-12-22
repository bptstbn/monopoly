using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public abstract class Square: ISquare 
    {

        public int Position {
            get; private set;
        }

        public string Name {
            get; private set;
        }


        public Square(int position, string name)
        {
            this.Position = position;
            this.Name = name;
        }

        public abstract void ActionOnPlayer(Player player);



    }
}
