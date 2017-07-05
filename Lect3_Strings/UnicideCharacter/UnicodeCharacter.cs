using System;

namespace UnicideCharacter
{
    class UnicodeCharacterrr
    {
        static void Main()
        {
            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                Console.Write( "\\u" + ((int)ch).ToString("X4"));
            }
        }
    }
}
