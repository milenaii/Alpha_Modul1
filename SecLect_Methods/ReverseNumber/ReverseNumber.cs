using System;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string revNum = "";
            for (int i = input.Length - 1; i >= 0 ; i--)
            {
                revNum += input[i];
            }
            Console.WriteLine(revNum);
        }
    }
}
