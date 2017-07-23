using System;

namespace FrequentNumber
{
    class StUpFrequentNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            ReadingArray(n, arr);
            FindMostFrequentNumber(n, arr);

        }

        private static void FindMostFrequentNumber(int n, int[] arr)
        {
            int frNum = 0;
            int maxFrNum = 1;
            int num = 1;

            for (int i = 0; i < n; i++)
            {
                frNum = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        frNum++;
                        if (frNum > maxFrNum)
                        {
                            maxFrNum = frNum;
                            num = arr[i];
                        }
                    }
                }
            }
            Console.WriteLine("{0} ({1} times)", num, maxFrNum);
        }

        private static void ReadingArray(int n, int[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
