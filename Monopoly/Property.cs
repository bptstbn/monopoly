using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Property : Asset
    {
        private double bareLandRent;
        private ColorCategory color;
        private int countHouses;

        public Property(string name, int price, double bareLandRent, ColorCategory color) : base(name, price)
        {
            this.bareLandRent = bareLandRent;
            this.color = color;
            this.countHouses = 0;
        }

        public ColorCategory Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public override ColorCategory ColorGroup()
        {
            return this.color;
        }

        public int CountHouses
        {
            get { return this.countHouses; }
            set { this.countHouses = value; }
        }

        public override double Rent(Dice dice)
        {
            int total;
            if (this.color == ColorCategory.Blue || this.color == ColorCategory.Violet)
            {
                total = 2;
            }
            else
            {
                total = 3;
            }
            int count = this.owner.Assets.Count(asset => asset.ColorGroup() == this.color);
            if (total == count)
            {
                return 2 * this.bareLandRent;
            }
            else
            {
                return this.bareLandRent;
            }
        }
        public override void Action(Player player, Dice dice, Game game)
        {
            if (this.owner == null)
            {
                int count = player.Assets.Count(asset => asset.ColorGroup() == this.color);
                if (count == 0)
                {
                    Console.WriteLine("You don't own any property of this color group for the moment.");
                }
                else if (count == 1)
                {
                    Console.WriteLine("You already own one property of this color group.");
                }
                else
                {
                    Console.WriteLine("You already own {0} properties of this color group.", count);
                }
            }
            base.Action(player, dice, game);
            // contray to other assets, we have to add the possibilty to buy houses
        }
    }
}
