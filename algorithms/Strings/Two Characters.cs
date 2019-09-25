
    // Complete the alternate function below.
    // Note : This solution From Discussions Not mine , i can't solve it for many times 
    // but i hope to understand this logic 

    static int alternate(string s)
    {
        int temp = 0;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[i] != s[j])
                {
                    bool gfn = true;
                    Stack<char> sta = new Stack<char>();
                    foreach (char c in s)
                    {
                        if (c == s[i] || c == s[j])
                        {
                            sta.Push(c);
                        }
                    }
                    char[] ca = sta.ToArray();
                    for (int k = 0; k < ca.Length - 1; k++)
                    {
                        if (ca[k] != ca[k + 1] && gfn == true)
                        {
                            gfn = true;
                        }
                        else
                        {
                            gfn = false;
                        }
                    }
                    if (gfn == true && ca.Length > temp)
                    {
                        temp = ca.Length;
                    }
                }
            }
        }
        return temp;
    }
