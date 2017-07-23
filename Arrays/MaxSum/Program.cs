using System;

namespace MaxSum
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum;
            int maxSum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = arr[i];
                for (int j = i + 1; j < n; j++)
                {
                    sum += arr[j];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
