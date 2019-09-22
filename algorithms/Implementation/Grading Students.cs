class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] >= 38)    //38 to make sure it will get next multiple 5
            {
                int NextMutiple = grades[i] + (5 - grades[i] % 5);

                if (NextMutiple - grades[i] < 3)    // 73 + (5-73%5) - 73
                {
                    grades[i] = NextMutiple;      //item1 = 73 + (5-73%5) =
                } 
            }
        }
        return grades;
    }

}