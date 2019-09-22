   
    /*
     * Complete the timeConversion function below.
     */

    static string timeConversion(string s) {

       DateTime Date = DateTime.Parse(s);
       return String.Format("{0:HH:mm:ss}", Date);

    }