

	// Add your code here
        public Difference(int[] arr)
    {
        this.elements = arr;
    }

    public int computeDifference()
    {
        maximumDifference = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            for (int j = 0; j < elements.Length; j++)
            {
                if (Math.Abs(elements[i]-elements[j])> maximumDifference)
                {
                    maximumDifference = Math.Abs(elements[i] - elements[j]);
                }
            }
        }
        return maximumDifference;
    }
