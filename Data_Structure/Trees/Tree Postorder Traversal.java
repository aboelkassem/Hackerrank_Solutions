

/* you only have to complete the function given below.  
Node is defined as  

class Node {
    int data;
    Node left;
    Node right;
}

*/

    public static void postOrder(Node root) {

        // Print left sub tree
        if (root.left != null)
        {
            postOrder(root.left); 
        }

        // Print Right sub tree
        if (root.right != null)
        {
            postOrder(root.right);
        }

        System.out.print(root.data+" "); // print head/first/parent value
    }

