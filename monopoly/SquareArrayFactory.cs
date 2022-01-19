using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monopoly
{
    abstract class SquareArrayFactory
    {
        private Square[] array = new Square[40];

        public SquareArrayFactory()
        {
            CreateSquareArray();
        }

        public abstract void CreateSquareArray();

        public Square[] Array
        {
            get { return this.array; }
        }

    }
}
