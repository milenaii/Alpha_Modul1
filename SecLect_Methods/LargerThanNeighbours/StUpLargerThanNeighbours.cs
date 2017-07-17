using System;


namespace LargerThanNeighbours
{
    class StUpLargerThanNeighbours
    {
        static void Main()
        {
            int sizeArr = int.Parse(Console.ReadLine());

            string[] inputArray = Console.ReadLine().Split();

            int[] array = new int [sizeArr];

            for (int i = 0; i < sizeArr; i++)
            {
                array[i] = int.Parse(inputArray[i]);
            }
            Console.WriteLine(CheckIsBetterThanNeigbours(sizeArr,array));
        }
        static int CheckIsBetterThanNeigbours(int sizeArr, int [] array)
        {
            int count = 0;
            for (int i = 1; i < sizeArr - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
