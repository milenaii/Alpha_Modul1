using System;

namespace OOP_2
{
    public class Square : Shape
    {
        public Square(double width)
            : base(width,width)
        {

        }
        public override double CalculateSurface()
        {
            return this.Width * this.Width;
        }

    }
}
