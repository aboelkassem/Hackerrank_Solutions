using System;
class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n <= 100 && n >= 1)
        {
            if (n%2 !=0)
            {
                Console.WriteLine("Weird");
            }
            else if (n%2 ==0 && (n <= 5 && n >= 2) )
            {
                Console.WriteLine("Not Weird");
            }
            else if (n % 2 == 0 && (n <= 20 && n >= 6))
            {
                Console.WriteLine("Weird");
            }
            else if (n % 2 == 0 && (n >=20))
            {
                Console.WriteLine("Not Weird");
            }
        }

    }
}

