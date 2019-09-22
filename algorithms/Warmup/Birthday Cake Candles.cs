   
 // Complete the birthdayCakeCandles function below.

    static int birthdayCakeCandles(int[] ar) {

        int numbers = 0 , max = 0;

        for (int i = 0; i < ar.Length; i++)
        {
            if (ar[i] >= max)
            {
                max = ar[i];
            }
        }

        for (int i = 0; i < ar.Length; i++)
        {
            if (ar[i] == max)
            {
                numbers++;
            }
        }

        return numbers;
    }
