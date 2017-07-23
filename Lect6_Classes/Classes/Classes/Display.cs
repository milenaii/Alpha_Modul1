using System;

namespace MobilePhoneDevices
{
    public class Display
    {
        //fields
        private double? size;
        private int? numberOfColors;
        //constr
        public Display(int? numberOFColors)
            : this(null, numberOFColors)
        {

        }
        public Display(double? size)
            : this(size, null)
        {

        }
        public Display(double? size, int? numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }
        //prop
        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (size <= 0)
                {
                    throw new ArgumentNullException("The size must be not less or equal to zero");
                }
                this.size = value;
            }
        }
        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (numberOfColors < 0)
                {
                    throw new ArgumentException("The Number Of colors must be not negstive!");
                }
                this.numberOfColors = value;
            }

        }
    }
}