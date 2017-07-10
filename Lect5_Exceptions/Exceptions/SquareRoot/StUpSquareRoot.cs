using System;

namespace SquareRoot
{
    class StUpSquareRoot
    {
        static void Main()
        {
            try
            {
                double n = double.Parse(Console.ReadLine());

                if (n < 0)
                {
                    throw new FormatException();
                }
                double sqrtNum = Math.Sqrt(n);
                Console.WriteLine("{0:0.000}",sqrtNum);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
