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
<<<<<<< HEAD
=======
            
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
            player.Action();
        }

    }
}
