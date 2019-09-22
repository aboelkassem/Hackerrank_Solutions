

// Complete the getNode function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static int getNode(SinglyLinkedListNode head, int positionFromTail) {

        int nodes = 0;
        SinglyLinkedListNode temp = head;
        // get the number of nodes in LinkedList
        while (temp != null)
        {
            temp = temp.next;
            nodes++;
        }

        // get the target node depend on number of nodes
        nodes -= positionFromTail;
        while (--nodes > 0)
        {
            head = head.next;
        }
        return head.data;

    }

