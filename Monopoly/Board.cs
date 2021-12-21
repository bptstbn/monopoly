using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public sealed class Board
    {
        private static Board instance = new Board();

        public static Board GetInstance()
        {
            return instance;
        }
    }
}
