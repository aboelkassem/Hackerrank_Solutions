

    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z)
    {
        string result = null;

        if (Math.Abs(x-z) < Math.Abs(y - z))
        {
            result = "Cat A";
        }
        else if (Math.Abs(x - z) > Math.Abs(y - z))
        {
            result = "Cat B";
        }
        else if (Math.Abs(x - z) == Math.Abs(y - z))
        {
            result = "Mouse C";
        }
        return result;
    }