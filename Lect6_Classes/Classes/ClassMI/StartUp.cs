using System;

namespace ClassMI
{
    class StartUp
    {
        static void Main()
        {
            GSM gsm = new GSM("Sams Galaxy", "Samsung","M.Todorova",new Battery("s6ghh", 20, 50, BatteryType.LiIon),new Display(12.5, 30), 12);

            //gsm.ToString();
            Console.WriteLine(gsm); ; // цялото име на класа

            //Console.WriteLine(GSM.IPhone4s);
            var display = new Display(10);
            display.PrintInfoDisplay();

        }
    }
}
