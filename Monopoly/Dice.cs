using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Dice
    {
        private int dieA; // between 1 and 6
        private int dieB;

        public Dice()
        {
            this.dieA = 0;
            this.dieB = 0;
        }

        public int DieA
        {
            get { return dieA; }
            set { dieA = value; }
        }

        public int DieB
        {
            get { return dieB; }
            set { dieB = value; }
        }

        public void Roll()
        {
            Random rdm = new Random();
            this.dieA = rdm.Next(1, 7);
            this.dieB = rdm.Next(1, 7);
        }
        
        public int Sum()
        {
            return this.dieA + this.dieB;
        }

        public bool IsDouble()
        {
            return (this.dieA == this.dieB)
        }
    }


}