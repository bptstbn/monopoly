using System;

namespace Monopoly
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Player a = new Player(150);

            //Console.WriteLine(a.Money);
            //a.Money = 170;
            //Console.WriteLine(a.Money);

            Go go = new Go(0, "GO");

            go.ActionOnPlayer(a);

            Console.WriteLine(a.Money);
            //Tax tax = new Tax(4, "Income Tax", 200);

            //Console.WriteLine(tax.Position + " " + tax.Name + " " + tax.Amount);

            ////tax.Name = "zbeub zbeub";

            //Console.WriteLine(tax.Position + " " + tax.Name + " " + tax.Amount);
        }
    }
}
