

	public static  Node insert(Node head,int data)
	{
      //Complete this method
        if (head == null) { return new Node(data); }
            
        head.next = insert(head.next, data);
        return head;
    }


