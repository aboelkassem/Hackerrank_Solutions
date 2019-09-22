class Solution {
    //Write your code here

    Stack<char> stk = new Stack<char>();
    Queue<char> que = new Queue<char>();

    public void enqueueCharacter(char c)
    {
        que.Enqueue(c);
    }
    public char dequeueCharacter()
    {
       return que.Dequeue();
    }
    public void pushCharacter(char c)
    {
        stk.Push(c);
    }
    public char popCharacter()
    {
        return stk.Pop();
    }

}