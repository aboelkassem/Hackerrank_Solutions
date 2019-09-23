   

   // Complete the superReducedString function below.
    static string superReducedString(string s)
    {
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                s = s.Substring(0, i - 1) + s.Substring(i + 1);
                i = 0;
            }
        }

        if (s.Length == 0)
            s = "Empty String";

        return s;


        //======================================> another solution With Stack <=====================
        //Stack<char> stack = new Stack<char>();

        //foreach (char c in s)
        //{
        //    char top = (stack.Count == 0) ? ' ' : stack.Peek(); // get the top element if not empty
        //    if (top == c)
        //        stack.Pop();
        //    else
        //        stack.Push(c);
        //}
        //char[] reduced = stack.ToArray();
        //Array.Reverse(reduced);

        //if (reduced.Length == 0)
        //    return "Empty String";
        //else
        //    return (new String(reduced));

    }
