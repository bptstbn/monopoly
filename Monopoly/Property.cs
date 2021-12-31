using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Property: Asset, ISquare
    {
<<<<<<< HEAD
        private ColorCategory color;

        public ColorCategory Color {
            get => color;
            set => color = value;
=======
        public ColorCategory Color {
            get; set;
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
        }


        public Property(int position, string name, int price, double mortgageValue, int rent, Player owner, ColorCategory color) : base(position, name, price, mortgageValue, rent, owner)
        {
<<<<<<< HEAD
            this.color = color;
=======
            this.Color = color;
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
        }

        

    }
}
