

/* 
   // This is Not My Solution , from Discussions ,Solution in O(n)
    class Node 
    	int data;
    	Node left;
    	Node right;
	*/

	public static void topView(Node root) {

      	int MAX = 500;    // Otherwise, MAX=getNodeCount(root);
    	int[] top = new int[MAX*2];

    	Queue<Object[]> queue = new ArrayDeque<>();
    	queue.add(new Object[]{root, MAX});

    	while(!queue.isEmpty()) {
        	Object[] array = queue.remove();
        	Node node = (Node)array[0];
       	 	Integer order = (Integer)array[1];
        	if(node == null) continue;

        	if(top[order] == 0) top[order] = node.data;
        	queue.add(new Object[]{node.left, order-1});
        	queue.add(new Object[]{node.right, order+1});
    	}

    	for(int data: top){
		if(data != 0) System.out.print(data + " ");
	}
      
    }

