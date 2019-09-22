 

   /*
     * Complete the getMoneySpent function below.
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        int cost = -1;
        for (int i = 0; i < keyboards.Length; i++)
        {
            for (int k = 0; k < drives.Length; k++)
            {
                if ((keyboards[i] + drives[k]) <= b)
                {
                    if (keyboards[i] + drives[k] > cost)
                        cost = keyboards[i] + drives[k];
                }
            }
        }

        if (cost == 0)
            return -1;
        else
            return cost;
    }
