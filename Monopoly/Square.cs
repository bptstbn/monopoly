using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public abstract class Square: ISquare 
    {
<<<<<<< HEAD
        protected int position;
        protected string name;


        public int Position {
            get => position;
            //set => position = value;
        }

        public string Name {
            get => name;
            //set => name = value;
=======

        public int Position {
            get; private set;
        }

        public string Name {
            get; private set;
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
        }


        public Square(int position, string name)
        {
<<<<<<< HEAD
            this.position = position;
            this.name = name;
=======
            this.Position = position;
            this.Name = name;
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
        }

        public abstract void ActionOnPlayer(Player player);



    }
}
