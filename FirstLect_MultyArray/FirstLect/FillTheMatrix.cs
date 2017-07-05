using System;

namespace FirstLect
{
    class FillTheMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string character = Console.ReadLine();

            int[,] matrix = new int[n, n];
            int num = 1;

            if (character == "a")
            {
                for (int col = 0; col < n; col++)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = num++;
                        //Console.WriteLine(matrix[row, col]);
                    }
                }
            }

            else if (character == "b")
            {
                for (int col = 0; col < n; col++)
                {
                    for (int row = 0; row < n; row++)
                    {
                        if (col % 2 == 0)
                        {
                            matrix[row, col] = row + 1 + col * n;
                        }
                        else if (col % 2 != 0)
                        {
                            matrix[row, col] = (col + 1) * n - row;
                        }
                    }
                }
            }
            else if (character == "c")
            {
                //under the main diagonal
                for (int i = n - 1; i >= 0; i--)
                {
                    int row = i;
                    int col = 0;
                    while (row < n)
                    {
                        matrix[row, col] = num;
                        row++;
                        col++;
                        num++;
                    }
                }
                //over the main diagonal
                for (int j = 1; j < n; j++)
                {
                    int col = j;
                    int row = 0;
                    while (row < n && col < n)
                    {
                        matrix[row, col] = num;
                        row++;
                        col++;
                        num++;
                    }
                }
            }
            //else if (character == "d")
            //{
            //    int offset = 0;

            //    while (true)
            //    {
            //        for (int row = 0; row < n; row++)
            //        {
            //            for (int col = 0; col < n; col++)
            //            {
            //                matrix[row, col] = num;
            //                num++;
            //            }
            //        }
            //    }


            //Print the result
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n ; col++)
                {
                    if (col == n - 1)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
