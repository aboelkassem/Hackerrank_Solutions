

/* Node is defined as :
 class Node 
    int data;
    Node left;
    Node right;
    
    */

	public static Node insert(Node root,int data) {

        Node newNode = new Node(data);

        // There is No Tree
        if (root == null) {
        return root = newNode;
        }

        // temp to search for suitable place depend on BST rule/algoirthem
        Node temp = root;

        // Using Recursion to search
        // for BST rule if data is less than target Node put it in left sub tree
        if (data <= temp.data)
        {
        	// and there is no node in it's left side , so put it here , else search again to reach
        	if (temp.left == null)
        	{
            		temp.left = newNode;
        	}
        	else
        	{
            		insert(temp.left, data);
        	}
        }
        // for BST rule if data is bigger than target Node put it in right sub tree
        else
        	{
        	// and there is no node in it's right side , so put it here , else search again to reach
        	if (temp.right == null)
        	{
            		temp.right = newNode;
        	}
        	else
        	{
            		insert(temp.right, data);
        	}
        }
          return root;
    	
    }

