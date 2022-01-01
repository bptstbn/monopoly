using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
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
        public static string GetSquareName(Board board, int size, int postion)
        {
            string name = board.Array[postion].Name;
            if (name.Length > size)
            {
                name = name.Substring(0, size - 1) + ".";
            }
            return String.Format("{0,-" + size.ToString() + "}", String.Format("{0," + ((size + name.Length) / 2).ToString() + "}", name));
        }
        /*
        public static string GetPlayersName(List<Player> players, int size, int postion)
        {
            string s = "";
            foreach (Player player in players)
            {
                name 
            }
            if (name.Length > size)
            {
                name = name.Substring(0, size - 1) + ".";
            }
            return "";
        }
        */
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
            string inside = new string(' ', size-1);
            for (int k = 0; k < size/2 - 1; k++)
            {
                Console.WriteLine("{0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {1}", "|" + inside, "|");
            }
            string lowerBorder = new string('‾', size);
            Console.WriteLine(" {0} {0} {0} {0} {0} {0} {0} {0} {0} {0} {0}", lowerBorder);
            Console.WriteLine();
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
            string border = new string('_', size);
            string spaces = new string(' ', (size+1)*9-3);
            string inside = new string(' ', size);
            if (i != 9 && j != 21)
            {
                Console.WriteLine(" {0} {1} {0}\n", border, spaces + "  ");
            }
            Console.WriteLine("{0} {1} {2}", "|" + GetSquareName(board, size, i) + "|", spaces, "|" + GetSquareName(board, size, j) + "|");
            for (int k = 0; k < size/2 - 1; k++)
            {
                Console.WriteLine("{0} {1} {0}", "|" + inside + "|", spaces);
            }
        }
        public static void DisplayBoard(Board board, List<Player> players, int size = 12)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DisplayRow(board, players, size, true);
            DisplayColumns(board, players, size);
            DisplayRow(board, players, size, false);
        }
    }
}
