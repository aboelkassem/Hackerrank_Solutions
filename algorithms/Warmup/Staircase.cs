// Complete the staircase function below.
    static void staircase(int n) {

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
        }
    }
