using System;
using System.IO;
//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

namespace _4.CompareTextFile
{
    class StUpCompareText
    {
        static void Main()
        {
            //Creating Two files:
            string fileOneName = "firstFile.txt";
            string fileTwoName = "secondFile.txt";

            StreamWriter writeFileOne = new StreamWriter(fileOneName);
            using (writeFileOne)
            {
                writeFileOne.WriteLine("Mi\r\nle\r\nna\r\ne\r\nstra6\r\nna!\r\nehee");
                //writeFileOne.WriteLine("le");
                //writeFileOne.WriteLine("na");
                //writeFileOne.WriteLine("e");
                //writeFileOne.WriteLine("stra6");
                //writeFileOne.WriteLine("na!");
                //writeFileOne.WriteLine("ehee");
            }
            StreamWriter writeFileTwo = new StreamWriter(fileTwoName);
            using (writeFileTwo)
            {
                writeFileTwo.WriteLine("Mi");
                writeFileTwo.WriteLine("le");
                writeFileTwo.WriteLine("na");
                writeFileTwo.WriteLine("e");
                writeFileTwo.WriteLine("super");
                writeFileTwo.WriteLine("!");
                writeFileTwo.WriteLine("ehee");
            }

            // Solve the task
            StreamReader readOne = new StreamReader("firstFile.txt");
            StreamReader readTwo = new StreamReader("secondFile.txt");


            using (readOne)
            {
                using (readTwo)
                {
                    string lineFirstFile = readOne.ReadLine();
                    string lineSecondFile = readTwo.ReadLine();

                    int countEqual = 0;
                    int countNotEqual = 0;

                    while (lineFirstFile != null)
                    {
                        if (lineFirstFile == lineSecondFile)
                        {
                            countEqual++;
                        }
                        else
                        {
                            countNotEqual++;
                        }
                        lineFirstFile = readOne.ReadLine();
                        lineSecondFile = readTwo.ReadLine();

                    }
                    Console.WriteLine(countEqual);
                    Console.WriteLine(countNotEqual);
                }
            }
        }
    }
}



