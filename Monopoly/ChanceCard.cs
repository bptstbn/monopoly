using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class ChanceCard: Square, ISquare
    {
        public ChanceCard(int position, string name) : base(position, name)
        {
        }

        public override void ActionOnPlayer(Player player)
        {
            ChanceCardGenerator.RandomCard(player);
        }

    }
}
