using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class GoToJail: Square, ISquare
    {
        public GoToJail(int position, string name) : base(position, name)
        {

        }

        public override void ActionOnPlayer(Player player)
        {
            player.State = new Imprisoned();
            
            player.Action();
        }

    }
}
