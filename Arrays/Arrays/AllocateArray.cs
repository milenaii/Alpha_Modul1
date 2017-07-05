using System;

namespace Arrays
{
    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] res = new int[n];

            for (int i = 0; i < n; i++)
            {
                res[i] =  i * 5;
                Console.WriteLine(res[i]);
            }

        }
    }
}
