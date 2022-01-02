using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Railroad : Asset
    {
        public Railroad(string name) : base(name, 200)
        {
        }

        public override double Rent(Dice dice)
        {
            int count = this.owner.Assets.Count(asset => asset is Railroad);
            if (count == 1)
            {
                return 25;
            }
            else if (count == 2)
            {
                return 50;
            }
            else if (count == 3)
            {
                return 100;
            }
            else // if (count == 4)
            {
                return 200;
            }
        }

        public override void Action(Player player, Dice dice, Game game)
        {
            if (this.owner == null)
            {
                int count = player.Assets.Count(asset => asset is Railroad);
                if (count == 0)
                {
                    Console.WriteLine("You don't own any railroad for the moment.");
                }
                else if (count == 1)
                {
                    Console.WriteLine("You already own one railroad.");
                }
                else
                {
                    Console.WriteLine("You already own {0} railroads.", count);
                }
            }
            base.Action(player, dice, game);
        }
    }
}
