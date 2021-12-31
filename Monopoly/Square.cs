using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public abstract class Square: ISquare 
    {
        protected int position;
        protected string name;


        public int Position {
            get => position;
            //set => position = value;
        }

        public string Name {
            get => name;
            //set => name = value;
        }


        public Square(int position, string name)
        {
            this.position = position;
            this.name = name;
        }

        public abstract void ActionOnPlayer(Player player);



    }
}
