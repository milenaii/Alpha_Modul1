using System;

namespace SubStringInText
{
    class StUpSubStringInText
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            pattern = pattern.ToLower();
            text = text.ToLower();

            int count = 0;
            int index = pattern.IndexOf(text);



            while (index > -1)
            {
                    count++;
                    index = pattern.IndexOf(text, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
