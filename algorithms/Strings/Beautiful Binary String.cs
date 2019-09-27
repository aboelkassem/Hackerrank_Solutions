   

   // Complete the beautifulBinaryString function below.

    static int beautifulBinaryString(string b)
    {
        var count = 0;
        var i = 0;

        while ((i = b.IndexOf("010", i)) != -1)
        {
            i += 3;
           count ++;
        }
        return count;

        // one line solution
        //return Regex.Matches(b, "010").Count;
    }