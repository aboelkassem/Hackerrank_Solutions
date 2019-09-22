    
    // Complete the kangaroo function below.
    // Note : This is Not My Solution , actually i don't understand the sum as well
    static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (x1 < x2 && v1 < v2)
            return  "NO";
        else if (x2 < x1 && v2 < v1)
            return  "NO";
        else if (x2 < x1)
        {
            //v2 > v1
            var numberOfJumps = ((double)(x1 - x2)) / (v2 - v1);
            //check whether number of jumps is a whole number  i.e no fractional part.
            if (numberOfJumps % 1 == 0)
                return  "YES";
            else
                return  "NO";
        }
        else
        {
            //v1 > v2
            var numberOfJumps = ((double)(x2 - x1)) / (v1 - v2);
            //check whether number of jumps is a whole number  i.e no fractional part.
            if (numberOfJumps % 1 == 0)
                return "YES";
            else
                return  "NO";
        }
    }