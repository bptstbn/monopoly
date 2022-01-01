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
        public static void DisplayBoard(Board board)
        {
            Square[] array = board.Array;
            Console.WriteLine();
            for (int i = 0; i <= 10; i++)
            {
                Console.Write("| {0} ", array[i].Name);
            }
            Console.Write("\n--------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i <= 8; i++)
            {
                Console.Write("\n| {0} \t|\t\t\t\t\t\t\t\t\t\t | {1} \t|", array[39 - i].Name, array[11 + i].Name);
            }
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------------------");
            for (int i = 30; i >= 20; i--)
            {
                Console.Write("| {0} ", array[i].Name);
            }
            Console.WriteLine("\n");
        }
    }
}
