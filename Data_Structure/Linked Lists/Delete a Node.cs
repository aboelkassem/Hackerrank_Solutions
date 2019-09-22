

// Complete the deleteNode function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position) {
        if (position == 0)
        {
            head = head.next;
        }
        else
        {
            SinglyLinkedListNode temp = head;
            for (int i = 0; i < position - 1 && temp.next != null; i++)   // to get the node before target node , second condition to make sure it's still at range of linkedlist
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;
        }
        return head;

    }

