using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class CommunityChest : Square
    {
        public CommunityChest() : base("Community Chest")
        {

        }

        public override void Action(Player player, Dice dice, Game game)
        {
            CommunityChestGenerator.RandomCard(player, dice, game);
        }
    }
}
