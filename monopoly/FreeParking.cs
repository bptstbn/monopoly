using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    public class FreeParking : Square
    {
        //private double amount;
        public static int amount2 = 0;


        public FreeParking() : base("Free Parking")
        {
            //this.amount = 0;
            amount2 = 0;
        }

        //public double Amount
        //{
        //    get { return this.amount; }
        //    set { this.amount = value; }
        //}

        //public override void Action(Player player, Dice dice, Game game)
        //{
        //    if (this.amount == 0)
        //    {
        //        Console.WriteLine("Unfortunately, there is no money to be collected at the moment.");
        //    }
        //    else
        //    {
        //        player.Money += this.amount;
        //        Console.WriteLine("Congratulations, you have just won {0}", this.amount);
        //        this.amount = 0;
        //    }
        //}

        public override void Action(Player player, Dice dice, Game game)
        {
            if (FreeParking.amount2 == 0)
            {
                Console.WriteLine("Unfortunately, there is no money to be collected at the moment.");
            }
            else
            {
                player.Money += FreeParking.amount2;
                Console.WriteLine("Congratulations, you have just won {0}", FreeParking.amount2);
                FreeParking.amount2 = 0;
            }
        }
    }
}