using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    public static class View
    {
        public static void DisplayDie(int die)
        {
            Console.OutputEncoding = Encoding.UTF8;
            switch (die)
            {
                case 1:
                    Console.Write(" _____\n|     |\n|  o  |\n|     |\n ‾‾‾‾‾");
                    break;
                case 2:
                    Console.Write(" _____\n|o    |\n|     |\n|    o|\n ‾‾‾‾‾");
                    break;
                case 3:
                    Console.Write(" _____\n|o    |\n|  o  |\n|    o|\n ‾‾‾‾‾");
                    break;
                case 4:
                    Console.Write(" _____\n|o   o|\n|     |\n|o   o|\n ‾‾‾‾‾");
                    break;
                case 5:
                    Console.Write(" _____\n|o   o|\n|  o  |\n|o   o|\n ‾‾‾‾‾");
                    break;
                case 6:
                    Console.Write(" _____\n|o   o|\n|o   o|\n|o   o|\n ‾‾‾‾‾");
                    break;
            }
            Console.WriteLine("");
        }
        public static void DisplayDice(Dice dice)
        {
            DisplayDie(dice.DieA);
            DisplayDie(dice.DieB);
            Console.WriteLine("You have just rolled the dice and obtained {0}", dice.Sum());
        }
        public static string GetSquareName(Board board, int size, int position)
        {
            string name = board.Array[position].Name;
            if (name.Length > size)
            {
                name = name.Substring(0, size - 1) + ".";
            }
            return String.Format("{0,-" + size.ToString() + "}", String.Format("{0," + ((size + name.Length) / 2).ToString() + "}", name));
        }
        public static string GetPlayersTokens(List<Player> players, int size, int postion)
        {
            string tokens = "";
            foreach (Player player in players)
            {
                if (player.Position == postion)
                {
                    tokens += player.Token + " ";
                }
            }
            if (tokens.Length > size)
            {
                tokens = tokens.Substring(0, size - 1) + ".";
            }
            return String.Format("{0,-" + size.ToString() + "}", String.Format("{0," + ((size + tokens.Length) / 2).ToString() + "}", tokens));
        }
        public static string GetSquareDetail(Board board, int size, int position)
        {
            string detail = "";
            Square square = board.Array[position];
            if (square is Asset)
            {
                Asset asset = (Asset)square;
                detail = "Price : " + asset.Price + "$";
            }
            else if (square is Tax)
            {
                Tax tax = (Tax)square;
                detail = "Pay " + tax.Amount + "$";
            }
            else if (square is FreeParking)
            {
                if (FreeParking.amount2 != 0)
                {
                    detail = "Collect " + FreeParking.amount2 + "$";
                }
            }
            else if (square is Go)
            {
                detail = "Collect 200$";
            }
            if (detail.Length > size)
            {
                detail = detail.Substring(0, size - 1) + ".";
            }
            return String.Format("{0,-" + size.ToString() + "}", String.Format("{0," + ((size + detail.Length) / 2).ToString() + "}", detail));
        }
        public static void DisplayRow(Board board, List<Player> players, int size, bool isUpperRow)
        {
            string upperBorder = new string('_', size);
            Console.WriteLine(" {0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {0}", upperBorder);
            if (isUpperRow)
            {
                for (int i = 10; i < 21; i++)
                {
                    if (i == 10)
                    {
                        Console.Write("|");
                    }
                    Console.Write(GetSquareName(board, size, i) + "|");
                }
            }
            else
            {
                Console.Write("|" + GetSquareName(board, size, 0) + "|");
                for (int i = 39; i > 29; i--)
                {
                    Console.Write(GetSquareName(board, size, i) + "|");
                }
            }
            Console.WriteLine();
            string inside = new string(' ', size - 1);
            for (int k = 0; k < size / 4 - 1; k++)
            {
                Console.WriteLine("{0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {1}", "|" + inside, "|");
            }
            if (isUpperRow)
            {
                for (int i = 10; i < 21; i++)
                {
                    if (i == 10)
                    {
                        Console.Write("|");
                    }
                    Console.Write(GetPlayersTokens(players, size, i) + "|");
                }
            }
            else
            {
                Console.Write("|" + GetPlayersTokens(players, size, 0) + "|");
                for (int i = 39; i > 29; i--)
                {
                    Console.Write(GetPlayersTokens(players, size, i) + "|");
                }
            }
            Console.WriteLine();
            for (int k = 0; k < size / 4 - 1; k++)
            {
                Console.WriteLine("{0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {1}", "|" + inside, "|");
            }
            if (isUpperRow)
            {
                for (int i = 10; i < 21; i++)
                {
                    if (i == 10)
                    {
                        Console.Write("|");
                    }
                    Console.Write(GetSquareDetail(board, size, i) + "|");
                }
            }
            else
            {
                Console.Write("|" + GetSquareDetail(board, size, 0) + "|");
                for (int i = 39; i > 29; i--)
                {
                    Console.Write(GetSquareDetail(board, size, i) + "|");
                }
            }
            Console.WriteLine();
            string lowerBorder = new string('‾', size);
            Console.WriteLine(" {0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {0}", lowerBorder);
        }
        public static void DisplayColumns(Board board, List<Player> players, int size)
        {
            for (int j = 21; j < 30; j++)
            {
                int i = 30 - j;
                DisplayPair(board, players, size, i, j);
            }
        }
        public static void DisplayPair(Board board, List<Player> players, int size, int i, int j)
        {
            string border = new string('-', size);
            string spaces = new string(' ', (size + 1) * 9 - 3);
            string inside = new string(' ', size);
            if (i != 9 && j != 21)
            {
                Console.WriteLine(" {0} {1} {0}", border, spaces + "  ");
            }
            Console.WriteLine("{0} {1} {2}", "|" + GetSquareName(board, size, i) + "|", spaces, "|" + GetSquareName(board, size, j) + "|");
            for (int k = 0; k < size / 4 - 1; k++)
            {
                Console.WriteLine("{0} {1} {0}", "|" + inside + "|", spaces);
            }
            Console.WriteLine("{0} {1} {2}", "|" + GetPlayersTokens(players, size, i) + "|", spaces, "|" + GetPlayersTokens(players, size, j) + "|");
            for (int k = 0; k < size / 4 - 1; k++)
            {
                Console.WriteLine("{0} {1} {0}", "|" + inside + "|", spaces);
            }
            Console.WriteLine("{0} {1} {2}", "|" + GetSquareDetail(board, size, i) + "|", spaces, "|" + GetSquareDetail(board, size, j) + "|");
        }
        public static void DisplayBoard(Board board, List<Player> players, int size = 14)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DisplayRow(board, players, size, true);
            DisplayColumns(board, players, size);
            DisplayRow(board, players, size, false);
        }
    }
}