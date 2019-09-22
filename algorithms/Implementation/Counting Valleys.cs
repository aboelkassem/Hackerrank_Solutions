

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        int sum = 0 ,count = 0;

        for (int i = 0; i < n; i++)
        {
            if (s[i] == 'U')
            {
                if (++sum == 0)
                    count++;
            }
            else if (s[i] == 'D')
            {
                sum--;
            }
        }
        return count;
    }
