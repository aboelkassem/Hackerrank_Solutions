

// Complete the insertNodeAtHead function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data) {
	
	SinglyLinkedListNode node = new SinglyLinkedListNode(data);

        if (llist == null)
        {
            llist = node;
        }
        else
        {
            SinglyLinkedListNode temp = llist;
            
            temp.next = llist;
            llist = temp;
        }
        return llist;

    }

