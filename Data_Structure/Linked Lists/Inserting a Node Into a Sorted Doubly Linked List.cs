

// Complete the sortedInsert function below.

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
    static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode head, int data) {

        DoublyLinkedListNode newNode = new DoublyLinkedListNode(data);

        if (head == null)
        {
            return newNode;
        }

        DoublyLinkedListNode temp = head;
        while (temp != null)
        {
            // Sort elements and adding when found suitble place
            if (temp.data >= newNode.data)
            {
                newNode.prev = temp.prev;
                newNode.next = temp; 
                temp.prev = newNode;
                if (newNode.prev == null)   // if the Node was the frist element of List
                {
                    return newNode;
                }
                else
                {
                    newNode.prev.next = newNode;
                    return head;
                }

            }
            //Special Case if get final Node To added it as Sorted
            if (temp.next == null)
            {
                newNode.prev = temp;
                newNode.next = null;
                temp.next = newNode;
                break;
            }
            temp = temp.next;
        }
        return head;
    }

