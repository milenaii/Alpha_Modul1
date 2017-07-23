using System;

namespace MobilePhoneDevices
{
    public class Display
    {
        //fields
        private double? size;
        private int? numberOfColors;

        //constr
        public Display (int? numberOFColors)
            :this(null,numberOFColors)
        {

        }

        public Display (double? size)
            :this(size, null)
        {

        }

        public Display(double? size, int? numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

    }
}
