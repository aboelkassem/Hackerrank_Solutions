    

     // Complete the caesarCipher function below.
    // Note : This solution From Discussions Not mine , i tried to solve it for many times but can't

    static string caesarCipher(string s, int k)
    {
        string result = "";

        foreach (var c in s)
        {
            if (!char.IsLetter(c))
                result = result + c;
            else
            {
                long numChar = Convert.ToInt64(c);
                k = k % 26;
                int checkUpperValue = 90, checkLowerValue = 122;

                int checkValue = Char.IsLower(c) ? checkLowerValue : checkUpperValue;

                if (numChar + k <= checkValue)
                    result = result + Convert.ToChar(numChar + k);
                else
                    result = result + Convert.ToChar(numChar + k - 26);

            }
        }
        return result;
    }