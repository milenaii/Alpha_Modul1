using System;

namespace OOP_2
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <=  0)
                {
                    throw new ArgumentException("Width cannot be negative number or zero");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be negative number or zero");
                }
                this.height = value;
            }
        }

        public abstract double CalculateSurface();


    }
}
