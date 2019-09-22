    

// Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores)
    {
        int high = scores[0] ,low = scores[0];
        int[] resault = new int[2];

        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] > high)
            {
                high = scores[i];
                resault[0]++;
            }
            else if (scores[i] < low)
            {
                low = scores[i];
                resault[1]++;
            }
        }

        return resault;
    }
