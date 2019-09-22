

// Complete the mergeLists function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {

        // check if any one is empty return the other
        if (head1 == null)
        {
            return head2;
        }
        if (head2 == null)
        {
            return head1;
        }

        //Make the Node point to next node less than it With Recursion
        if (head1.data < head2.data)
        {
            head1.next = mergeLists(head1.next, head2);
            return head1;
        }
        else
        {
            head2.next = mergeLists(head1, head2.next);
            return head2;
        }
    }

