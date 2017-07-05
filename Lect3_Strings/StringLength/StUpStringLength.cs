using System;

namespace StringLength
{
    class StUpStringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();

            // 1 way

            //for (int i = input.Length; i < 20; i++)
            //{
            //    input = input + "*";
            //}
            //Console.WriteLine(input);

            //2 way

            input = input.PadRight(20,'*');
            Console.WriteLine(input);

        }
    }
}
