

/* you only have to complete the function given below.  
Node is defined as  

class Node {
    int data;
    Node left;
    Node right;
}

*/

    public static void inOrder(Node root) {
        // Print left sub tree
        if (root.left != null)
        {
            inOrder(root.left); 
        }

        System.out.print(root.data+" "); // print head/first/parent value

        // Print Right sub tree
        if (root.right != null)
        {
            inOrder(root.right);
        }
    }

