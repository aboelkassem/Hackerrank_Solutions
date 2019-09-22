

/* 
    
    class Node 
    	int data;
    	Node left;
    	Node right;
	*/
	public static void levelOrder(Node root) {

        if (root == null){return;} // empty tree

       // Queue to store The left and right of Node , Print it as FIFO
       Queue<Node> q = new LinkedList<>();
       q.add(root);

       while (!q.isEmpty())
       {
	   // Store First level of tree in front of queue, and delete it from queue to next .... looping to print all nodes as FIFO
           Node current = q.poll();
           
           // Print The Front in Queue
           System.out.print(current.data + " ");

           // Repeate this until reaching to leaf
           if (current.left != null){ q.add(current.left); }
           if (current.right != null) { q.add(current.right); }
       }
      
    }

