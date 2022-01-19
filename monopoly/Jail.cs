using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    class Jail : Square
    {
        public Jail() : base("Jail / Just Visiting")
        {
        }

        public override void Action(Player player, Dice dice, Game game)
        {
            if (player.Free)
            {
                Console.WriteLine("You're just visiting.");
            }
            else
            {
                Console.WriteLine("You are in jail.");
            }
        }
    }
}