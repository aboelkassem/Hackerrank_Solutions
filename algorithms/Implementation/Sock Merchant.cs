	
    // Complete the sockMerchant function below.
    // Simple Solution with Linq expression

    static int sockMerchant(int n, int[] ar)
    {
        int result = ar.GroupBy(x => x).Where(y => y.Count() >= 2).Select(z => z.Count() / 2).Sum();
        return result;
    }