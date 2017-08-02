using System;

namespace FirstLargerThanNeigbours
{
    class FirstLargest
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(' ');

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(input[i]);

            }
            Console.WriteLine(FindFirstThanNeigbours(n, nums));
        }

        private static int FindFirstThanNeigbours(int n, int[] nums)
        {
            for (int i = 1; i < n - 1; i++)
            {
                if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                {
                    return i;
                }
                else
                {

                }
            }
            return -1;
        }
    }
}
