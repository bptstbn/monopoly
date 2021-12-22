using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Jail: Square, ISquare
    {
        public Jail(int position, string name) : base(position, name)
        {

        }

        public override void ActionOnPlayer(Player player)
        {
            Console.WriteLine("Your visiting the Jail");
        }
    }
}
