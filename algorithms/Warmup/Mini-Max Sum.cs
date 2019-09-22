    
// Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {
        long sum = 0;
        long min = arr.Min();
        long max = arr.Max();
        for (int i = 0; i < arr.Length; i++)
        {
            sum = sum + arr[i];
        }
        Console.WriteLine("{0} {1}", sum - max, sum - min); 	//minimum = SumOfAllElements - MaximumElement , maximum = SumOfAllElements - minimumElement 
    }