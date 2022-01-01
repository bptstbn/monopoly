using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Chance : Square
    {
        public Chance() : base("Chance")
        {

        }

        public override void Action(Player player, Dice dice, Game game)
        {
            ChanceGenerator.RandomCard(player, dice, game);
        }

    }
}
