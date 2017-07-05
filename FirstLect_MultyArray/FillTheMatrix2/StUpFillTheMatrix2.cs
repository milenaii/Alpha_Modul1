using System;
//mi
namespace FillTheMatrix2
{
    class StUpFillTheMatrix2
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


            if (character == "c")
            {
                int row = 0;
                int col = 0;

                ////Populates under the main diagonal
                //for (int i = n - 1; i >= 0; i--)
                //{
                //    row = i;
                //    col = 0;
                //    while (row < n && col < n)
                //    {
                //        matrix[row++, col++] = counter++;
                //    }
                //}
                ////populates over the main diagonal
                //for (int j = 1; j < n; j++)
                //{
                //    col = j;
                //    row = 0;
                //    while (row < n && col < n)
                //    {
                //        matrix[row++, col++] = counter++;
                //    }
                //}


                row = n - 1;
                col = 0;
                while (row < n && col < n)
                {
                    //if (row == n - 1)
                    //{
                    //    col--;
                    //}
                    matrix[row++, col++] = counter++;
                    row--;
                }
                col = 1;
                row = 0;
                while (row < n && col < n)
                {
                    matrix[row++, col++] = counter++;
                    col++;
                }

            }




            if (character == "d")
            {
                int moveRow = 1;
                int moveCol = 0;

                int curRow = 0;
                int curCol = 0;

                //down         //right        //up            //left
                //moveRow = 1; //moveRow = 0; //moveRow = -1; //moveRow = 0;
                //moveCol = 0; //moveCol = 1; //moveCol = 0;  //moveCol = -1;

                while (counter <= n * n)
                {
                    matrix[curRow, curCol] = counter++;

                    if (curRow == n || curRow == -1 || curCol == n || curCol == -1 || matrix[curRow, curCol] != 0)
                    {
                        if (moveRow == 1 && moveCol == 0)
                        {
                            moveRow = 0;
                            moveCol = 1;
                        }
                        if (moveRow == 0 && moveCol == 1)
                        {
                            moveRow = -1;
                            moveCol = 0;
                        }
                        if (moveRow == -1 && moveCol == 0)
                        {
                            moveRow = 0;
                            moveCol = -1;
                        }
                        curRow += moveRow;
                        curCol += moveCol;
                    }
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
}
