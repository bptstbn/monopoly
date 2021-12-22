using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    class Property: Asset, ISquare
    {

        public Property(int position, string name, int price, double mortgageValue, int rent, Player owner) : base(position, name, price, mortgageValue, rent, owner)
        {

        }

    }
}
