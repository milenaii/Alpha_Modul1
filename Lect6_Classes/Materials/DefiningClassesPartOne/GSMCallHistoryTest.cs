using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartOne
{
    public class GSMCallHistoryTest
    {
        public static void Test()
        {
            GSM gsmNote =
                new GSM("Note 7", "Samsung", 1000M, "Viktor",
                new Battery("Samsung", 100, 40, BatteryType.LiIon),
                new Display(1024, 1024));

            Call firstCall = new Call();
            firstCall.DateTime = new DateTime(2017, 7, 18);
            firstCall.DialedPhoneNumber = "08888888";
            firstCall.DurationInSeconds = 60;

            Call secondCall = new Call();
            secondCall.DateTime = new DateTime(2016, 7, 18);
            secondCall.DialedPhoneNumber = "088888884";
            secondCall.DurationInSeconds = 65;

            gsmNote.AddCall(firstCall);
            gsmNote.AddCall(secondCall);

            foreach (Call call in gsmNote.CallHistory)
            {
                Console.WriteLine(call);
            }
        }
    }
}
