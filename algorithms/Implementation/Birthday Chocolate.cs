    

// Complete the birthday function below.
    static int birthday(List<int> s, int d, int m)
    {
        int count = 0;
        for (int i = 0; i < s.Count - m + 1; i++)
        {
            int temp = 0;
            for (int j = 0; j < m; j++) // steps will move as it's month
            {
                temp += s[i+j]; //every step will add them to temp variable
            }

            if (temp == d) //if it's sum match with the day of his birthday
            {
                count++;
            }
        }
        return count;
    }