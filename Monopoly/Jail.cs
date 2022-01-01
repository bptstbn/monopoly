using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Jail : Square
    {
        public Jail() : base("Jail / Just Visiting")
        {
        }

        public override void Action(Player player, Dice dice)
        {
            if (player.IsPrisoner())
            {
                Console.WriteLine("You are in jail");
            }
            else
            {
                Console.WriteLine("You're just visiting");
            }
        }
    }
}
