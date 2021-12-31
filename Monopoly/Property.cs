using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Property: Asset, ISquare
    {
        private ColorCategory color;

        public ColorCategory Color {
            get => color;
            set => color = value;
        }


        public Property(int position, string name, int price, double mortgageValue, int rent, Player owner, ColorCategory color) : base(position, name, price, mortgageValue, rent, owner)
        {
            this.color = color;
        }

        

    }
}
