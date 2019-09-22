   
 // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {

        float pos = 0, neg = 0, zeros = 0;

        for (int i = 0; i < arr.Count(); i++)
        {
            if (arr[i] > 0)
            {
                pos++;
            }
            if (arr[i] < 0)
            {
                neg++;
            }
            if (arr[i] == 0)
            {
                zeros++;
            }
        }

        Console.WriteLine(pos / arr.Count());
        Console.WriteLine(neg / arr.Count());
        Console.WriteLine(zeros / arr.Count());
    }