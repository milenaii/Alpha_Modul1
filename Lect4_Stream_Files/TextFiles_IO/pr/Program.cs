using System;
using System.IO;
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
namespace _6.SaveSortedNames
{
    class StUpSaveSortedName
    {
        static void Main()
        {
            int[] mi = new int[] { 3, 2, 5, 1 };
                for (int i = 0; i < mi.Length - 1; i++)
                {
                    for (int j = i + 1; j < mi.Length; j++)
                    {
                        if (string.Compare(mi[i], mi[j]) == -1)
                        {
                            string temp = "";
                            temp = mi[i];
                            input[i] = input[j];
                            input[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < mi.Length; i++)
                {
                    Console.WriteLine(mi[i]);
                }
            }
        }
    }
}
