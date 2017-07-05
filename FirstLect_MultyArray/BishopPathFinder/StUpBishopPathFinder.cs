using System;

namespace BishopPathFinder
{
    class StUpBishopPathFinder
    {
        static void Main()
        {
            //Read the input
            string[] input = Console.ReadLine().Split(' ');
            int r = int.Parse(input[0]);
            int c = int.Parse(input[1]);

            int[,] matrix = new int[r, c];

            FillTheMatrix(r, c, matrix);

            int moves = int.Parse(Console.ReadLine());
            for (int i = 0; i < moves; i++)
            {
                string[] dk = Console.ReadLine().Split(' ');
                //string d = dk[0];
                //int k = int.Parse(dk[1]);
            }
            //PrintTheMatrix(r, c, matrix);




        }

        static int[,] FillTheMatrix(int r, int c, int [,] matrix)
        {
            int fillNumber = 0;
            int row = 0;
            int col = 0;
            //Populates under the main diagonal

            for (int i = r - 1; i >= 0; i--)
            {
                row = i;
                col = 0;
                while (row < r && col < c)
                {
                    matrix[row++, col++] = fillNumber;
                }
                fillNumber += 3;
            }
            //populates over the main diagonal
            for (int j = 1; j < c; j++)
            {
                col = j;
                row = 0;
                while (row < r && col < c)
                {
                    matrix[row++, col++] = fillNumber;
                }
                fillNumber += 3;
            }
            return matrix;
        }

        static void PrintTheMatrix(int r, int c, int[,] matrix)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (j == c - 1)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
//Fill The matrix
//int row = r - 1;
//int col = 0;
//while (row >= 0)
//{
//    matrix[row, col] = fillNumber;
//    row--;
//    while (row < r - 1)
//    {
//        matrix[row, col] = fillNumber;
//    }
//    fillNumber += 3;
//}
//row = 0;
//col = 0;
//while (col < c)
//{
//    matrix[row, col] = fillNumber;
//    col++;
//    fillNumber += 3;
//    //while (col < c)
//    //{
//    //    matrix[row++, col++] = fillNumber;
//    //}
//}