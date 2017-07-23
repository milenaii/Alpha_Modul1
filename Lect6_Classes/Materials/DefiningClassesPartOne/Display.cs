using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class Display
    {
        public Display()
            : this(0, 0)
        {
        }

        public Display(double size, int numberOfColours)
        {
            this.Size = size;
            this.NumberOfColours = numberOfColours;
        }

        public double Size
        {
            get;
            set;
        }

        public int NumberOfColours
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"Size - {this.Size}; Number of colours - {this.NumberOfColours}";
        }
    }
}
