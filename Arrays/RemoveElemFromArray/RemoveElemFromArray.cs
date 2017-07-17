using System;

namespace RemoveElemFromArray
{
    class RemoveElemFromArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i]  > arr[i + 1])
                {
                    count++;
                   
                }
            }

        }
    }
}
