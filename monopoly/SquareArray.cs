using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    class SquareArray : SquareArrayFactory
    {
        public override void CreateSquareArray()
        {
            Array[0] = new Go();
            Array[1] = new Property("Mediterranean Avenue", 60, 2, ColorCategory.Violet);
            Array[2] = new CommunityChest();
            Array[3] = new Property("Baltic Avenue", 60, 4, ColorCategory.Violet);
            Array[4] = new Tax("Income Tax", 200);
            Array[5] = new Railroad("Reading Railroad");
            Array[6] = new Property("Oriental Avenue", 100, 6, ColorCategory.Cyan);
            Array[7] = new Chance();
            Array[8] = new Property("Vermont Avenue", 100, 6, ColorCategory.Cyan);
            Array[9] = new Property("Connecticut Avenue", 120, 8, ColorCategory.Cyan);
            Array[10] = new Jail();
            Array[11] = new Property("St. Charles Place", 140, 10, ColorCategory.Pink);
            Array[12] = new Utility("Electric Company");
            Array[13] = new Property("States Avenue", 140, 10, ColorCategory.Pink);
            Array[14] = new Property("Virginia Avenue", 160, 12, ColorCategory.Pink);
            Array[15] = new Railroad("Pennsylvania Railroad");
            Array[16] = new Property("St. James Place", 180, 14, ColorCategory.Orange);
            Array[17] = new CommunityChest();
            Array[18] = new Property("Tennessee Avenue", 180, 14, ColorCategory.Orange);
            Array[19] = new Property("New York Avenue", 200, 16, ColorCategory.Orange);
            Array[20] = new FreeParking();
            Array[21] = new Property("Kentucky Avenue", 220, 18, ColorCategory.Red);
            Array[22] = new Chance();
            Array[23] = new Property("Indiana Avenue", 220, 18, ColorCategory.Red);
            Array[24] = new Property("Illinois Avenue", 240, 20, ColorCategory.Red);
            Array[25] = new Railroad("B. & O. Railroad");
            Array[26] = new Property("Atlantic Avenue", 260, 22, ColorCategory.Yellow);
            Array[27] = new Property("Ventnor Avenue", 260, 22, ColorCategory.Yellow);
            Array[28] = new Utility("Water Works");
            Array[29] = new Property("Marvin Gardens", 280, 24, ColorCategory.Yellow);
            Array[30] = new GoToJail();
            Array[31] = new Property("Pacific Avenue", 300, 26, ColorCategory.Green);
            Array[32] = new Property("North Carolina Avenue", 300, 26, ColorCategory.Green);
            Array[33] = new CommunityChest();
            Array[34] = new Property("Pennsylvania Avenue", 320, 28, ColorCategory.Green);
            Array[35] = new Railroad("Short Line Railroad");
            Array[36] = new Chance();
            Array[37] = new Property("Park Place", 350, 35, ColorCategory.Blue);
            Array[38] = new Tax("Luxury Tax", 75);
            Array[39] = new Property("Boardwalk", 400, 50, ColorCategory.Blue);
        }
    }
}