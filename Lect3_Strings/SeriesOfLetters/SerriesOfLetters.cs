using System;
using System.Text;

namespace SeriesOfLetters
{
    class SerriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();
            output.Append(input[0]);

            for (int i = 1; i < input.Length ; i++)
            {
                if (input[i - 1] != input[i])
                {
                    output.Append(input[i]);
                }
            }
            Console.WriteLine(output);
        }
    }
}
