

	/*
    	class Node 
    	int data;
    	Node left;
    	Node right;
	*/
	public static int height(Node root) {
      		// Write your code here.
        	Node temp = root;

        	if (temp == null)
        	{
            		return -1; // height of empty subtree , after the leaf node .... exist recursion condition to reach for empty node 
        	}

        	int Left_SubTree = height(temp.left);
        	int Right_SubTree = height(temp.right);

        	return 1 + Math.max(Left_SubTree, Right_SubTree); // apply returning recursive on every node from empty node ==> leaf ==> parent tree ==> ....etc head
    	}

