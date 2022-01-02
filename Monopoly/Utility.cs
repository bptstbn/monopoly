using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Utility : Asset
    {
        public Utility(string name) : base(name, 150)
        {
        }

        public override double Rent(Dice dice)
        {
            int count = this.owner.Assets.Count(asset => asset is Utility);
            if (count == 1)
            {
                return 4 * dice.Sum();
            }
            else // if (count == 2)
            {
                return 10 * dice.Sum();
            }
        }

        public override void Action(Player player, Dice dice, Game game)
        {
            if (this.owner == null)
            {
                int count = player.Assets.Count(asset => asset is Utility);
                if (count == 0)
                {
                    Console.WriteLine("You don't own any utility for the moment.");
                }
                else if (count == 1)
                {
                    Console.WriteLine("You already own one utility.");
                }    
            }
            base.Action(player, dice, game);
        }
    }
}
