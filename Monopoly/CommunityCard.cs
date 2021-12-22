using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class CommunityCard: Square, ISquare
    {
        public CommunityCard(int position, string name) : base(position, name)
        {
        }

        public override void ActionOnPlayer(Player player)
        {
            CommunityCardGenerator.RandomCard(player);
        }
    }
}
