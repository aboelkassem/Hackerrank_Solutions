    
    // Complete the dayOfProgrammer function below.
    // Note : This is simple way to solve this sum , it's Not My Solution but hope to understand the idea

    static string dayOfProgrammer(int year)
    {
        if (year % 4 == 0 && (year < 1918 || year % 400 == 0 || year % 100 != 0))
            return "12.09." + year;
        else if (year == 1918)
            return "26.09.1918";
        return "13.09." + year;
    }