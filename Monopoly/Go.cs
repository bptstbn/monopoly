using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Go : Square, ISquare
    {
        private const int moneyGo = 200;

        public int MoneyGo {
            get => moneyGo;
        }

        public Go(int position, string name) : base(position, name)
        {
            //moneyGo déjà défini comme constante donc pas besoin de l'instancier 
        }

        public override void ActionOnPlayer(Player player)
        {
            player.Money += moneyGo;

            Console.WriteLine("You've passed the Go square, and won " + moneyGo + "$.");
        }

        

    }
}
