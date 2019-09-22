    

    // Complete the designerPdfViewer function below.
    // Note : This Solution from discussions Not mine , one line code

    static int designerPdfViewer(int[] h, string word)
    {
         return word.Max(c => h[(int)c - 97]) * word.Length;
    }