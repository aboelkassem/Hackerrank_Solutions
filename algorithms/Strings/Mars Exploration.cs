   

    // Complete the marsExploration function below.
    static int marsExploration(string s)
    {
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i % 3 == 0 || i % 3 == 2)   // the first and last char of 3 words (SOS)
            {
                if (s[i] != 'S') count++;
            }
            else                            // middle char
            {
                if (s[i] != 'O') count++;
            }
        }
        return count;
    }
