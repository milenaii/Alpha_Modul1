using System;

namespace MobilePhoneDevices
{
    public class GSMCallHistoryTest
    {
        public void CallHistory()
        {
            DateTime firstDate = new DateTime(2016, 05, 29, 15, 43, 35);
            DateTime secondDate = new DateTime(2016, 04, 09, 05, 40, 02);
            DateTime thirdDate = new DateTime(2016, 03, 12, 15, 42, 16);

            Call your1Call = new Call(firstDate, "02254879", 65m);
            Call your2Call = new Call(secondDate, "05894566", 210m);
            Call your3Call = new Call(thirdDate, "05894566", 20m);

            double? pricePerMin = 0.37;

           
        }
    }
}
