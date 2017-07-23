using System;
using System.Text;
using System.Numerics;

namespace Alpha_Exam1
{
    class SendMeTheCode
    {
        static void Main()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Read
            string input = Console.ReadLine();
            int l = input.Length;

            if (input[0] == '-')
            {
                BigInteger[] num = new BigInteger[l - 1];
                int y = 1;
                while (y <= l - 1)
                {
                    num[y - 1] = int.Parse(input[y].ToString());
                    y++;
                }
                //Reverse

                BigInteger[] numR = new BigInteger[l - 1];

                for (int i = 0; i < l - 1; i++)
                {
                    numR[i] = num[l - 2 - i];
                }
                BigInteger result = 0;

                //Decode
                for (int i = 0; i < l - 1; i++)
                {
                    if ((i) % 2 == 0)
                    {
                        numR[i] = (i + 1) * numR[i] * (i + 1);
                    }
                    else
                    {
                        numR[i] = numR[i] * numR[i] * (i + 1);

                    }
                    result += numR[i];
                }

                if (result % 10 == 0)
                {
                    Console.WriteLine("{0}", result);
                    Console.WriteLine("Big Vik wins again!");
                }
                else
                {
                    BigInteger lengthMess = result % 10;
                    int s = (int)result % 26;
                    int startMess = s + 1;

                    string[] r = new string[(int)lengthMess];

                    for (int i = 0; i < lengthMess; i++)
                    {
                        if (s + i <= 25)
                        {
                            r[i] = alphabet[s + i].ToString();
                        }
                        else
                        {
                            s = s % (26 - i);
                            r[i] = alphabet[s].ToString();
                            s = s - i;
                        }
                    }
                    Console.WriteLine(result);
                    for (int i = 0; i < r.Length; i++)
                    {
                        Console.Write(r[i]);
                    }
                }
            }
            else
            {
                BigInteger[] num = new BigInteger[l];
                for (int i = 0; i < l; i++)
                {
                    num[i] = int.Parse(input[i].ToString());
                }

                //Reverse

                BigInteger[] numR = new BigInteger[l];

                for (int i = 0; i < l; i++)
                {
                    numR[i] = num[l - 1 - i];
                }
                BigInteger result = 0;

                //Decode
                for (int i = 0; i < l; i++)
                {
                    if ((i) % 2 == 0)
                    {
                        numR[i] = (i + 1) * numR[i] * (i + 1);
                    }
                    else
                    {
                        numR[i] = numR[i] * numR[i] * (i + 1);

                    }
                    result += numR[i];
                }

                if (result % 10 == 0)
                {
                    Console.WriteLine("{0}", result);
                    Console.WriteLine("Big Vik wins again!");
                }
                else
                {
                    BigInteger lengthMess = result % 10;
                    int s = (int)result % 26;
                    int startMess = s + 1;

                    string[] r = new string[(int)lengthMess];

                    for (int i = 0; i < lengthMess; i++)
                    {
                        if (s + i <= 25)
                        {
                            r[i] = alphabet[s + i].ToString();
                        }
                        else
                        {
                            s = s % (26 - i);
                            r[i] = alphabet[s].ToString();
                            s = s - i;
                        }
                    }
                    Console.WriteLine(result);
                    for (int i = 0; i < r.Length; i++)
                    {
                        Console.Write(r[i]);
                    }
                }
            }
        }
    }
}