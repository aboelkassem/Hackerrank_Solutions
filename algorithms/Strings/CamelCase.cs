    

   // Complete the camelcase function below.

    static int camelcase(string s)
    {
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if ((int)s[i] >= 65 && (int)s[i] <= 90)
            {
                count++;
            }
        }
        return ++count;
    }