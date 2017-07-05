using System;

namespace CorrectBracets
{
    class StUpCorrectBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int countLeftBrackets = 0;
            int countRightBrackets = 0;


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    countLeftBrackets++;
                }
                if (input[i] == ')')
                {
                    countRightBrackets++;
                }
            }
            if (countRightBrackets == countLeftBrackets)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }


        }
    }
}
