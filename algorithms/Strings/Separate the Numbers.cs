
    // Complete the separateNumbers function below.
    // Note : This is not my solution , it's from discussions but it's very simple to understand

    static void separateNumbers(string s)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
        {
            Console.WriteLine("NO");
            return;
        }
        else if (s.Length == 1)
        {
            Console.WriteLine("NO");
            return;
        }

        var windowMin = 1;
        var windowMax = s.Length / 2;

        for (var window = windowMin; window <= windowMax; window++)
        {
            long firstElement = long.Parse(GetFirstElement(s, window));
            int requestTextLength = s.Length;
            var generatedSequence = GenerateTextSequence(firstElement, requestTextLength);
            if (generatedSequence == s)
            {
                Console.WriteLine("YES " + firstElement);
                return;
            }
        }
        Console.WriteLine("NO");

    }

    static string GetFirstElement(string input, int window)
    {
        return input.Substring(0, window);
    }

    static string GenerateTextSequence(long startValue, int requestTextLength)
    {
        var sequence = new StringBuilder(requestTextLength);
        while (sequence.Length < requestTextLength)
            sequence.Append(startValue++);
        return sequence.ToString();
    }