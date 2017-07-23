using MobilePhoneDevices;
using System;

namespace MobilePhoneDevicess
{
    public class Start
    {
        public static void Main()
        {
            GSM yourGSM = new GSM("Samsung Galaxy s8", "Samsung Electronics");

            Battery blackBattery = new Battery("ha", BatteryType.LiIon);
            Display yourDisplay = new Display(12.3, 40);

            Console.WriteLine(yourGSM);

            GSMtest.PrintGsms();

            //GSMtest.PrintIPhone4s();  

        }
    }
}

