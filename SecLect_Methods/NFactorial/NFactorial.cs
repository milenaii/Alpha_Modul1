using System;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fact = 1;
            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    fact *= i;
                }
                Console.WriteLine(fact * n);

            }
        }
    }
}
