 

   // Complete the gemstones function below.
    static int gemstones(string[] arr)
    {
        // ready method on HashSet class to contain only elements that are present in that object and in the specified collection
        var result = new HashSet<char>(arr[0]);
        for (int i = 1; i < arr.Length; ++i)
        {
            result.IntersectWith(arr[i]);
        }
        return result.Count;
    }
