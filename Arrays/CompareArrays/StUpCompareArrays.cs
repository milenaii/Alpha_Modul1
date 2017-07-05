using System;
namespace CompareArrays
{
    class StUpCompareArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                secArr[i] = int.Parse(Console.ReadLine());
            }
            bool areSame = false;

            for (int i = 0; i < n; i++)
            {
                if (firstArr[i] == secArr[i])
                {
                    areSame = true;
                }
                else
                {
                    areSame = false;
                    break;
                }
            }
            if (areSame == false)
            {
                Console.WriteLine("Not equal");
            }
            else
            {
                Console.WriteLine("Equal");
            }

        }
    }
}
