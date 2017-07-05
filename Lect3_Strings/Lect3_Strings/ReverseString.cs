using System;

namespace Lect3_Strings
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string reverseStr = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseStr += input[i];
            }
            Console.WriteLine(reverseStr);
        }
    }
}
