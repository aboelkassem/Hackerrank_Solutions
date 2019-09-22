

// Complete the reverse function below.

    /*
     * For your reference:
     *
     * DoublyLinkedListNode {
     *     int data;
     *     DoublyLinkedListNode next;
     *     DoublyLinkedListNode prev;
     * }
     *
     */
    static DoublyLinkedListNode reverse(DoublyLinkedListNode head) {

        if (head == null)
        {
            return null;
        }

        while (head != null)
        {
            // Recontrol links of the doublyLinkedList , every time it move doing these things
            DoublyLinkedListNode temp = head.prev;
            head.prev = head.next;
            head.next = temp;

            if (head.prev == null)
            {
                return head;
            }
            head = head.prev;
        }

        return head;
    }

