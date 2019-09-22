

class Student : Person{
    private int[] testScores;  
  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string firstName , string lastName , int id , int[] scores)
    {

        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.testScores = scores;
    }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
     public char Calculate()
    {
        int[] sum = new int[this.testScores.Length];
        for (int i = 0; i < this.testScores.Length; i++)
        {
            sum[i] += this.testScores[i];
        }
        double grade = sum.Average();
        if (grade >= 90 && grade <= 100)
        {
            return 'O';
        }
        else if (grade >= 80 && grade < 90)
        {
            return 'E';
        }
        else if (grade >= 70 && grade < 80)
        {
            return 'A';
        }
        else if (grade >= 55 && grade < 70)
        {
            return 'P';
        }
        else if (grade >= 40 && grade < 55)
        {
            return 'D';
        }
        else if (grade < 40)
        {
            return 'T';
        }
        return Convert.ToChar(null);
    }
}

