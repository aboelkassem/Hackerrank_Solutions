

// Complete the insertNodeAtPosition function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position) {
        SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

        if (position == 0)
        {
            newNode.next = head;
            head = newNode;
            return head;
        }

        SinglyLinkedListNode temp = head;

        for (int i = 0; i < position - 1 && temp.next != null; i++)   // to get the node before target node , second condition to make sure it's still at range of linkedlist
        {
            temp = temp.next;
        }

        newNode.next = temp.next;
        temp.next = newNode;
        return head;

    }

