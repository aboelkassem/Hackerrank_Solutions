 

   // Complete the minimumNumber function below.
    static int minimumNumber(int n, string password)
    {
        // Return the minimum number of characters to make the password strong
        int NotValids = 0;

        if (!password.Any(char.IsDigit))    // if doesn't contain any Digits
        {
            NotValids++;
        }
        if (!password.Any(char.IsLower))    // if doesn't contain any letters in Lower case
        {
            NotValids++;
        }
        if (!password.Any(char.IsUpper))    // if doesn't contain any letters in Upper case
        {
            NotValids++;
        }

        var specialCharacters = new Regex("^[a-zA-Z0-9 ]*$");   // if doesn't contain any special characters as regular expression
        if (specialCharacters.IsMatch(password))
        {
            NotValids++;
        }

        int lengthDifference = 6 - password.Length;         // if password length is less than 6 
        if (lengthDifference > 0 && NotValids <= lengthDifference) 
        {
            return lengthDifference;
        }
        return NotValids;
    }