using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    class GoToJail : Square
    {
        public GoToJail() : base("Go To Jail")
        {
        }

        public override void Action(Player player, Dice dice, Game game)
        {
            player.PutInJail();
            Console.WriteLine("You are now in jail.");
        }
    }
}