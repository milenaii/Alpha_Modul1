using System;

namespace AppearanceCount
{
    class StUpAppearanceCount
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            string [] nums = input.Split();
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(nums[i]);
            }

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(AppearanceCount(n, numbers, x));
            
        }

        static int AppearanceCount(int n, int [] matrix, int x)
        {
            int appearance = 0;

            for (int i = 0; i < n; i++)
            {
                if (matrix[i] == x)
                {
                    appearance++;
                }
            }
            return appearance;
        }
    }
}
