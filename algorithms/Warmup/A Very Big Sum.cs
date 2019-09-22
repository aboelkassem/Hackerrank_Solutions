    

    // Complete the aVeryBigSum function below.
    static long aVeryBigSum(long[] ar) {

        long sum = 0;
        for (var i = 0; i <= ar.Length - 1; i++)
        {
            sum += ar[i];
        }
        return sum;
    }
