using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Go : Square, ISquare
    {
<<<<<<< HEAD
        private const int moneyGo = 200;

        public int MoneyGo {
            get => moneyGo;
        }

        public Go(int position, string name) : base(position, name)
        {
            //moneyGo déjà défini comme constante donc pas besoin de l'instancier 
=======
        public int MoneyGo {
            get; set;
        }
        public Go(int position, string name, int money = 200) : base(position, name)
        {
            this.MoneyGo = money;
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
        }

        public override void ActionOnPlayer(Player player)
        {
<<<<<<< HEAD
            player.Money += moneyGo;

            Console.WriteLine("You've passed the Go square, and won " + moneyGo + "$.");
        }

        
=======
            player.Money += this.MoneyGo;

            Console.WriteLine("you've passed the Go square, and won " + this.MoneyGo + "$.");
        }


>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3

    }
}
