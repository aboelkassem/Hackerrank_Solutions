   

    // Complete the hackerrankInString function below.
    // using queue
    static string hackerrankInString(string s)
    {
        var hackerrank = new Queue<char>("hackerrank".ToCharArray());
        foreach (char c in s)
        {
            if (c == hackerrank.Peek()) // if the char is equal to top of hackerrank queue characters... as sequential
                hackerrank.Dequeue();

            if (hackerrank.Count == 0)  // if empty this mean it's taken all char in queue, and it's already contain this string
                return "YES";
        }

        return "NO";
    }