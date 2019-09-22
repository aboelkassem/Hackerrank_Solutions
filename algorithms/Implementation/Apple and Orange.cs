    
// Complete the countApplesAndOranges function below.

    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int applesCount = 0, orangesCount = 0;

        foreach (var apple in apples)
        {
            var fallingApplePosition = a + apple;
            if (fallingApplePosition >= s && fallingApplePosition <= t)     //range of house position
            {
                applesCount++;
            }
        }

        foreach (var orange in oranges)
        {
            var fallingOrangePosition = b + orange;
            if (fallingOrangePosition >= s && fallingOrangePosition <= t)   //range of house position
            {
                orangesCount++;
            }
        }

        Console.WriteLine(applesCount);
        Console.WriteLine(orangesCount);
    }