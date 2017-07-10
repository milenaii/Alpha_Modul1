using System;
//Write a method ReadNumber(int start, int end) that enters an integer number in a given range ( start, end ).
//If an invalid number or non-number text is entered, the method should throw an exception.Using this method write a program that enters 10 numbers: a1, a2, ..., a10, such that 1 < a1< ... < a10< 100
namespace _2.EnterNumbers
{
    class StUpEnterNumbers
    {
        static void Main()
        {
           // Console.WriteLine("Enter 10 int numbers, each one on the next line: ");

            int[] nums = new int[10];

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    nums[i] = int.Parse(Console.ReadLine());

                    if ((nums[0] <= 1) || (nums[9] >= 100))
                    {
                        throw new Exception();
                    }
                }

                for (int i = 0; i < 10 - 1; i++)
                {
                    if (ReadNumber(nums[i], nums[i + 1]))
                    {
                        continue;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                Console.WriteLine($"1 < {nums[0]} < {nums[1]} < {nums[2]} < {nums[3]} < {nums[4]} < {nums[5]} < {nums[6]} < {nums[7]} < {nums[8]} < {nums[9]} < 100");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }
        static bool ReadNumber(int start, int end)
        {
            if (start < end)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
