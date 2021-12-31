using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public interface ISquare
    {
<<<<<<< HEAD
        //int Position {
        //    get;
        //}
        //string Name {
        //    get;
        //}
=======
        int Position { get; }
        string Name {get;}
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
        void ActionOnPlayer(Player player);
    }
}
