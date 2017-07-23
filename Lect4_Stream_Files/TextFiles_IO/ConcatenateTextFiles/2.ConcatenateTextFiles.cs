using System;
using System.IO;

namespace ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main()
        {
            //Creating Two files:
            string fileOneName = "fileOne.txt";
            string fileTwoName = "fileTwo.txt";

            StreamWriter writeFileOne = new StreamWriter(fileOneName);
            using (writeFileOne)
            {
                writeFileOne.Write("Milena");
            }
            StreamWriter writeFileTwo = new StreamWriter(fileTwoName);
            using (writeFileTwo)
            {
                writeFileTwo.Write("Ivanova");
            }

            //Reading and taking Contents of the both files
            string readOne = "";
            StreamReader readFileOne = new StreamReader(fileOneName);
            using (readFileOne)
            {
               readOne = readFileOne.ReadToEnd();
            }
            StreamReader readFileTwo = new StreamReader(fileTwoName);
            string readTwo = "";
            using (readFileTwo)
            {
               readTwo = readFileTwo.ReadToEnd();
            }

            //writing final file
            string fileConcatName = "fileConcate.txt";
            StreamWriter writeConcatFile = new StreamWriter(fileConcatName);
            using (writeConcatFile)
            {
                writeConcatFile.Write(readOne + " " + readTwo);
            }

        }
    }
}
