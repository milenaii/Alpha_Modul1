using System;

namespace CountThem
{
    class CountThem
    {
        static void Main()
        {
            string end = "";

            string input = Console.ReadLine();

            while (input != "{!}")
            {
                int st = input.IndexOf("@");

                //chech first letter - is it letter or _ :
                string firstSymbol = input.Substring(st + 1, 1);
                firstSymbol.ToCharArray();

                if (firstSymbol[0].IsLetter() == true)
                {

                }

                //Check for escaping symbols
                if (input.IndexOf("/*") < st && input.IndexOf("*/") > st)
                {
                    continue;
                }
                ////Check for comment - not a variable
                //if (input.IndexOf("//") == 0 || input.IndexOf("#") == 0)
                //{
                //    continue;
                //}

                //is letter || is _
                //..........

                //where is the end of the variable: - method
                end = FindTheEndOfVariable(end, input, st);



                input = Console.ReadLine();
            }
            Console.WriteLine(end);
        }


        public static string FindTheEndOfVariable(string sub, string input, int st)
        {
            if (input.IndexOf("'", st) > -1)
            {
                sub = input.Substring(st, (input.IndexOf("'", st) - st));
            }
            else if (input.IndexOf('"', st) > -1)
            {
                sub = input.Substring(st, (input.IndexOf('"', st) - st));
            }
            else if (input.IndexOf(")", st) > -1)
            {
                sub = input.Substring(st, (input.IndexOf(')', st) - st));
            }
            else if (input.IndexOf(" ", st) > -1)
            {
                sub = input.Substring(st, (input.IndexOf(" ", st) - st));
            }
            else if (input.IndexOf(',', st) > -1)
            {
                sub = input.Substring(st, (input.IndexOf(',', st) - st));
            }
            else if (input.IndexOf('[', st) > -1)
            {
                sub = input.Substring(st, (input.IndexOf('[', st) - st));
            }
            else if (input.IndexOf(';', st) > -1)
            {
                sub = input.Substring(st, (input.IndexOf(';', st) - st));
            }

            return sub;
        }
    }
}
