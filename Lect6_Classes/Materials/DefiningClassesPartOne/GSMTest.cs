using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class GSMTest
    {
        public static void Test()
        {
            GSM gsmNote =
                new GSM("Note 7", "Samsung", 1000M, "Viktor",
                new Battery("Samsung", 100, 40, BatteryType.LiIon),
                new Display(1024, 1024));
            
            gsmNote.AddCall(new Call());


            GSM gsmHtc =
                new GSM("OneTouch", "HTC", 9000M, "Ivan",
                new Battery("HTC", 105, 43, BatteryType.NiCd),
                new Display(1024, 1024));
            
            GSM[] gsms = new GSM[] { gsmNote, gsmHtc, GSM.IPhone4S };
            foreach (GSM gsm in gsms)
            {
                Console.WriteLine(gsm);
            }
        }
    }
}
