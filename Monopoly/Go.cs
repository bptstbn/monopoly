using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Go : Square, ISquare
    {
        public int MoneyGo {
            get; set;
        }
        public Go(int position, string name, int money = 200) : base(position, name)
        {
            this.MoneyGo = money;
        }

        public override void ActionOnPlayer(Player player)
        {
            player.Money += this.MoneyGo;

            Console.WriteLine("you've passed the Go square, and won " + this.MoneyGo + "$.");
        }



    }
}
