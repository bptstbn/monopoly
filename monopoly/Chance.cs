using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    class Chance : Square
    {
        public Chance() : base("Chance")
        {

        }

        public override void Action(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Press any key to pick a Chance card.");
            Console.ReadKey();
            Console.WriteLine();
            ChanceGenerator.RandomCard(player, dice, game);
        }
    }
}