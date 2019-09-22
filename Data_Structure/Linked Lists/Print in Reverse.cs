

    // Complete the reversePrint function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static void reversePrint(SinglyLinkedListNode head) {
        if (head == null)
        {
            return;
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

	// Print The Reversed LinkedList
        SinglyLinkedListNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }

