   

   // Complete the theLoveLetterMystery function below.

    static int theLoveLetterMystery(string s)
    {
        int count = 0;
        for (int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--)   // looping in elements,(j)From Last and (i)From beginning
            count += Math.Abs(s[i] - s[j]);
        return count;

        //for (int i = 0; i < s.Length / 2; ++i)
        //{
        //    count += Math.Abs(s[i] - s[s.Length - i - 1]);
        //}
    }