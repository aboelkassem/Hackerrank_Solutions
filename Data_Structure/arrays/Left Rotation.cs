using System;

class Solution
{
    public static int[] rotLeft(int[] a, int d)
    {
        int[] result = new int[a.Length];

        for (int i = d; i < a.Length; i++)
        {
            result[i - d] = a[i];
        }

        for (int j = 0; j < d; j++)
        {
            result[a.Length - d + j] = a[j];
        }

        return result;
    }
    static void Main(string[] args)
    {
        string[] nd = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(nd[0]);
        int d = Convert.ToInt32(nd[1]);
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        int[] result = rotLeft(a, d);
        Console.WriteLine(string.Join(" ", result));
    }
}
