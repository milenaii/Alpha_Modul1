using System;

namespace FirstLect
{
    class FillTheMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            string ch = Console.ReadLine();

            if (ch == "a")
            {
                int count = 1;
                for (int c = 0; c < n; c++)
                {
                    for (int r = 0; r < n; r++)
                    {
                        matrix[r, c] = count;
                        count++;
                    }
                }
                // PrintTheMatrix(n, matrix);
            }
            if (ch == "aa")                          // 16 15 14 13
            {                                        // 12 11 10 9
                int count = 1;                       // 8 7 6 5
                for (int r = n - 1; r >= 0; r--)     // 4 3 2 1
                {
                    for (int c = n - 1; c >= 0; c--)
                    {
                        matrix[r, c] = count;
                        count++;
                    }
                }
                // PrintTheMatrix(n, matrix);
            }
            if (ch == "aaa")
            {                                        // 4 3 2 1
                int count = 1;                       // 8 7 6 5
                for (int r = 0; r < n; r++)           // 12 11 10 9         
                {                                     // 16 15 14 13
                    for (int c = n - 1; c >= 0; c--)
                    {
                        matrix[r, c] = count;
                        count++;
                    }
                }
                PrintTheMatrix(n, matrix);
            }

            if (ch == "b")
            {
                int count = 1;                              // 1 8 9 16
                for (int c = 0; c < n; c++)                 // 2 7 10 15
                {                                           // 3 6 11 14
                    if (c % 2 == 0)                         // 4 5 12 13
                    {
                        for (int r = 0; r < n; r++)
                        {
                            matrix[r, c] = count;
                            count++;
                        }
                    }
                    else
                    {
                        for (int r = n - 1; r >= 0; r--)
                        {
                            matrix[r, c] = count;
                            count++;
                        }
                    }
                }
               // PrintTheMatrix(n, matrix);
            }
            if (ch == "c")
            {

                ////1 way
                //int count = 1;
                //int r = n - 1;
                //int c = 0;
                ////under main diagonal
                //for (int i = n - 1; i >= 0; i--)
                //{
                //    r = i;
                //    c = 0;
                //    while (r < n && c < n)
                //    {
                //        matrix[r++, c++] = count++;
                //    }

                //}
                ////over main diagonal
                //for (int i = 1; i < n; i++)
                //{
                //    r = 0;
                //    c = i;
                //    while (r < n && c < n)
                //    {
                //        matrix[r++, c++] = count++;
                //    }
                //}

                //2 way

                int count = 1;
                int r = n - 1;
                int c = 0;

                while (count <= n * n)
                {
                     count = FillDiagonal(n, matrix, count, r, c);

                    if (r == 0)
                    {
                        c++;
                    }
                    else
                    {
                        r--;
                    }
                }
               // PrintTheMatrix(n, matrix);
            }
            
            if (ch == "d")
            {
                int moveRow = 1;
                int moveCol = 0;

                int curRow = 0;
                int curCol = 0;

                int count = 1;
                //down         //right        //up            //left
                //moveRow = 1; //moveRow = 0; //moveRow = -1; //moveRow = 0;
                //moveCol = 0; //moveCol = 1; //moveCol = 0;  //moveCol = -1;

                while (count <= n * n)
                {
                    if (curRow == n || curRow == -1 || curCol == n || curCol == -1 || matrix[curRow, curCol] != 0)
                    {
                        //change directions
                        if (moveRow == 1 && moveCol == 0) // down
                        {
                            curRow--;
                            moveRow = 0;
                            moveCol = 1;
                            curCol += moveCol;
                            curRow += moveRow;
                        }
                        else if (moveRow == 0 && moveCol == 1) // right
                        {
                            curCol--;
                            moveRow = -1;
                            moveCol = 0;
                            curRow += moveRow;
                            curCol += moveCol;
                        }
                        else if (moveRow == -1 && moveCol == 0) // up
                        {
                            curRow++;
                            moveRow = 0;
                            moveCol = -1;
                            curCol += moveCol;
                            curRow += moveRow;
                        }
                        else if (moveRow == 0 && moveCol == -1) //left
                        {
                            curCol++;
                            moveRow = 1;
                            moveCol = 0;
                            curRow += moveRow;
                            curCol += moveCol;
                        }
                    }
                    matrix[curRow, curCol] = count++;
                    curRow += moveRow;
                    curCol += moveCol;
                }
            }
            PrintTheMatrix(n, matrix);
        }
        private static int FillDiagonal(int n, int[,] matrix, int count, int r, int c)
        {
            while (r < n && c < n)
            {
                matrix[r++, c++] = count++;
            }
            return count;
        }

        static void PrintTheMatrix(int n, int[,] matrix)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (c == n - 1)
                    {
                        Console.WriteLine(matrix[r, c]);
                    }
                    else
                    {
                        Console.Write(matrix[r, c] + " ");
                    }
                }
            }
        }


    }
}
