using System;

namespace GetLargestNumber
{
    class StUpGetLargestNumber
    {
        static int GetLargestNumber(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            else 
            {
                return b;
            }
        }

        static void Main()
        {
            string [] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            Console.WriteLine(GetLargestNumber(GetLargestNumber(a,b),c));

        }
    }
}
