using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Board
    {
        private static Board instance = new Board();
        private Square[] array = new Square[40];

        public Square[] Array
        {
            get { return this.array; }
        }

        public static Board GetInstance()
        {
            return instance;
        }

        private Board()
        {
            var squareArray = new SquareArray();
            array = squareArray.Array;
        }
    }
}