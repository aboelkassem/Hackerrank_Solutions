   

    // Complete the funnyString function below.
    static string funnyString(string s)
    {
        for (int i = 0; i < s.Length - 1; i++)
        {
            int r = (s.Length - 1) - i; // get element in Reverse

            if (Math.Abs((int)s[i] - (int)s[i + 1]) != Math.Abs((int)s[r] - (int)s[r - 1]))	//adjacent difference in two strings
                return "Not Funny";
        }
        return "Funny";
    }