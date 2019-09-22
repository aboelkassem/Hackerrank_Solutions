

    // Complete the reverse function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode reverse(SinglyLinkedListNode head) {

        if (head == null)
        {
            return head;
        }
        SinglyLinkedListNode prev, curr, next;
        prev = next = null;
        curr = head;

        while (curr != null)    // not reached to last element
        {
            // Links Controll
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        // move head to pointer on last element
        head = prev;
        return head;
    }

