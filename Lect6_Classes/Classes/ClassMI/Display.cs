using System;

namespace ClassMI
{
    class Display
    {
        public Display(double size)
            : this(size, 0)
        {

        }
        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get;
            set;
        }
        public int NumberOfColors
        {
            get;
            set;
        }
        public void PrintInfoDisplay()
        {
            Console.WriteLine($"Size - {Size}, NumberOfColors - {NumberOfColors}");
        }

    }
}
