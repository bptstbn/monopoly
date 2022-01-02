using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Program
    {      
        static void Main(string[] args)
        {
            /*
            var a = new SquareArray(); //use of Factory Method
            Square[] b = a.Array;
            foreach (Square s in b)
            {
                Console.WriteLine(s.Name);
            }
            Board board = Board.GetInstance();
            View.DisplayBoard(board);
            Console.ReadKey();
            */
            Game game = new Game();
            Console.WriteLine("\t=== YOU ARE PLAYING MONOPOLY ===");
            // View.DisplayBoard(game.Board);
            View.DisplayBoard(game.Board, game.Players);
            Controller.Initialize(game);
            do
            {
                Controller.PlayTurn(game);
            } while (true);
            
        }
    }
}
