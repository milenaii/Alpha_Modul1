using System;

namespace FillCccc
{
    class FillCcc
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string character = Console.ReadLine();

            int[,] matrix = new int[n, n];

            int counter = 1;

            if (character == "a")
            {
                for (int col = 0; col < n; col++)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = counter++;
                    }
                }
            }
            if (character == "b")
            {
                for (int col = 0; col < n; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < n; row++)
                        {
                            matrix[row, col] = counter++;
                        }
                    }
                    else
                    {
                        for (int row = n - 1; row >= 0; row--)
                        {
                            matrix[row, col] = counter++;
                        }
                    }
                }
            }
            //if (character == "c")
            //{

            //    // diagon
            //    for (int col = 0; col < n - 1; col++)
            //    {
            //        for (int row = n - 1; row > 0; row--)
            //        {

            //            if (row == n - 1)
            //            {
            //                matrix[row, col] = counter++;
            //            //    row--;
            //            }

            //            matrix[row++, col++] = counter++;

            //            //if (row == 0)
            //            //{
            //            //    col++;
            //            //}
            //            if (counter == 16)
            //            {
            //                break;
            //            }
            //        }
            //    }

            //}

            if (character == "c")
            {
                int curRow = n - 1;
                int curCol = 0;

                while (curRow >= 0)
                {
                    matrix[curRow, curCol] = counter++;
                    curRow--;
                    while (curRow <= n)
                    {
                        matrix[curRow++, curCol++] = counter++;
                    }
                }


                //Print
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (col == n - 1)
                        {
                            Console.WriteLine(matrix[row, col]);
                        }
                        else
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                    }
                }
            }
        }
        //static int FillC( int [,] matrix, int n, int curRow, int curCol, int value)
        //{
        //    matrix[curRow++, curCol++] = value++;
        //    return value;
        //}
    }

}