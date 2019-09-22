  

   /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     * Note : This is Not My Sulotion , but it's very sample to understand
     */

    public static int pickingNumbers(List<int> a)
    {
        var maxCount = 0;
        var sortedList = a.OrderBy(x => x).ToList();

        for (int i = 0; i < sortedList.Count; i++)
        {
            var currentCount = 1;
            if (i > 0)
                if (sortedList[i] == sortedList[i - 1])
                    continue;

            for (int j = i + 1; j < sortedList.Count; j++)
            {
                if (Math.Abs(sortedList[j] - sortedList[i]) <= 1)
                    currentCount++;
                else
                    break;
            }

            if (currentCount > maxCount)
                maxCount = currentCount;
        }
        return maxCount;
    }
