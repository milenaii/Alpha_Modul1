using System;

namespace MaxIncreaseSeq
{
    class MaxIncreasSeq
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int seq = 1;
            int maxSeq = 1;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] + 1 <= arr[i + 1])
                {
                    seq++;
                    if (maxSeq < seq)
                    {
                        maxSeq = seq;
                    }
                }
                else
                {
                    seq = 1;
                }
            }
            Console.WriteLine(maxSeq);

        }
    }
}
