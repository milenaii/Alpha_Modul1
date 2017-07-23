using System;
using System.Collections.Generic;

namespace SelectionSort
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int [] arr = new int [n];
            int [] sortArr = new int [n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int temp = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}