using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class FreeParking: Square, ISquare
    {
<<<<<<< HEAD
        private double availableCash;
        public double AvailableCash {
            get => availableCash;
            set => availableCash = value;
=======
        public double AvailableCash {
            get; set;
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
        }

        public FreeParking(int position, string name, double availableCash = 0) : base(position, name)
        {
<<<<<<< HEAD
            this.availableCash = availableCash;
=======
            this.AvailableCash = availableCash;
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
        }

        public override void ActionOnPlayer(Player player)
        {
<<<<<<< HEAD

            if (availableCash == 0) {
                Console.WriteLine("No cash available");
            }
            else {
                player.Money += availableCash;
                availableCash = 0;
                Console.WriteLine(player.Name + " won " + availableCash + "$.");
=======
            if (this.AvailableCash == 0) {
                Console.WriteLine("No cash available");
            }
            else {
                player.Money += this.AvailableCash;
                this.AvailableCash = 0;
                Console.WriteLine(player.Name + " won " + this.AvailableCash + "$.");
>>>>>>> b199c6a4c78e29de3b235a5d2c8e791c7cdc60e3
            }

        }

    }
}
