using System;

namespace CompareCharArrays
{
    class StUpCompareCharArrays
    {
        static void Main()
        {
            string array1 = Console.ReadLine();
            string array2 = Console.ReadLine();

            switch (string.Compare(array1, array2))
            {
                case -1:
                    Console.WriteLine("<");
                    break;
                case 0:
                    Console.WriteLine("=");
                    break;
                case 1:
                    Console.WriteLine(">");
                    break;
            }
        }
    }
}
