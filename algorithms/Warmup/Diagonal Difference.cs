class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int left = 0, right = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            for (int k = 0; k < arr.Count; k++)
            {
                if (i == k)
                {
                    left += arr[i][k];
                }

                if (i == arr.Count - k - 1)
                {
                    right += arr[i][k];
                }
            }
        }

        return Math.Abs(left - right);

        /*
        ======== Another Solution ========================
        for (int i = 0; i < arr.Count; i++)
        {
            int j = arr.Count - i - 1;  // get from last element

            left  += arr[i][i]; // When i == j
            right += arr[i][j]; 
        }
        */
    }

}