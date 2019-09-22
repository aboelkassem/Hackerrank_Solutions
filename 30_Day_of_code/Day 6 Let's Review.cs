using System;
class Program
{
    static void Main(string[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine());
        if (T>=1 && T <=10)
        {
            for (int i = 0; i < T; i++)
            {
                string S = Console.ReadLine();
                if (S.Length>=2 && S.Length<=10000)
                {
                    for (int j = 0; j < S.Length; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(S[j]);
                        }
                    }
                    Console.Write(" ");
                    for (int j = 0; j < S.Length; j++)
                    {
                        if (j % 2 != 0)
                        {
                            Console.Write(S[j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

