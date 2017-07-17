using System;

namespace MaxKSum
{
    class MaxKSum
    {
        static void Main()
        {
            //Read input
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //Sort array
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];   //swap the elem
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
            int sumK = 0;
            for (int i = n - 1; i >= n - k; i--)
            {
                sumK += arr[i];
            }
            Console.WriteLine(sumK);

        }
    }
}
