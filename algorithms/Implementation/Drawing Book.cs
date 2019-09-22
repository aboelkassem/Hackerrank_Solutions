    
    /*
     * Complete the pageCount function below.
     */

    static int pageCount(int n, int p)
    {
        int total = n / 2;
        int right = p / 2;
        int left = total - right;

        return Math.Min(right, left);

        // Solution through one line of code
        //return Math.Min(p / 2, n / 2 - p / 2);
    }