 

   // Complete the hurdleRace function below.
    static int hurdleRace(int k, int[] height)
    {
        int max = height.Max();
        return max - k <= 0 ? 0 : max - k;
    }