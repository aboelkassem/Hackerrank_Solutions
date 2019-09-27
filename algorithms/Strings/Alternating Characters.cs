   

   // Complete the alternatingCharacters function below.
    static int alternatingCharacters(string s)
    {
        int deletions = 0;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i-1] == s[i])
            {
                deletions++;
            }
        }
        return deletions;
    }