using System;

namespace SeqLect_Methods
{
    class StUpSayHello
    {
        static string SayHello()
        {
           // Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            return name;
        }


        static void Main()
        {
            Console.WriteLine("Hello, {0}!",SayHello());

        }
    }
}
