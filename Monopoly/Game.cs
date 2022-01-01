using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Game
    {
        Board board;
        List<Player> players;

        public Game()
        {
            board = Board.GetInstance();
            players = new List<Player>();
        }

        public Board Board
        {
            get { return this.board; }
        }

        public List<Player> Players
        {
            get { return this.players; }
            set { this.players = value; }
        }
    }
}
