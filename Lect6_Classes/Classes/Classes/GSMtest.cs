using System;

namespace MobilePhoneDevices
{
    public static class GSMtest
    {
        static GSM[] gsms = new GSM[]
      {
                new GSM("Galaxy S7", "Samsung"),
                new GSM("Lenovo", "Lenove Group","I.Ivanov"),
                new GSM("iPhone 6s", "Apple","T.Todorov")
      };

        public static void PrintGsms()
        {
            foreach (GSM gsm in gsms)
            {
                Console.WriteLine(gsm.ToString());
            }
        }
        public static void PrintIPhone4s()
        {
            Console.WriteLine(GSM.iPhone4s.ToString());
        }

    }
}
