   

    // Complete the pangrams function below.

    static string pangrams(string s)
    {
        if (s.ToLower().Where(char.IsLetter).Distinct().Count() == 26)  // if the distinct letters equal 26 that mean contain all alphabet
        {
            return "pangram";
        }
        else
        {
            return "not pangram";
        }
    }
