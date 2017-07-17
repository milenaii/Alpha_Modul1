using System;
//too long time
namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            //Console.WriteLine(121 % 7);
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            bool[] bo = new bool[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }

            for (int j = n - 1; j >0 ; j--)
            {
                for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                {
                    if (arr[j] % i == 0)
                    {
                        bo[j] = true;
                    }
                }
            }

            for (int i = n - 1; i > 0; i--)
            {
                if (bo[i] == false)
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
            }


        }
    }
}
