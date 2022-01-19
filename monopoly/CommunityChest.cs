using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    class CommunityChest : Square
    {
        public CommunityChest() : base("Community Chest")
        {

        }

        public override void Action(Player player, Dice dice, Game game)
        {
            Console.WriteLine("Press any key to pick a Community Chest card.");
            Console.ReadKey();
            Console.WriteLine();
            CommunityChestGenerator.RandomCard(player, dice, game);
        }
    }
}