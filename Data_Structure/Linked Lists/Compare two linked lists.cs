

// Complete the CompareLists function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {

        SinglyLinkedListNode temp1 = head1;
        SinglyLinkedListNode temp2 = head2;
        int count1 = 0, count2 = 0, count = 0;

        while (temp1 != null)
        {
            count1++;
            temp1 = temp1.next;
        }
        while (temp2 != null)
        {
            count2++;
            temp2 = temp2.next;
        }

        if (count1 != count2)
        {
            return false;
        }
        else
        {
            while (head1 != null || head2 != null)
            {
                if (head1.data == head2.data)
                {
                    count++;
                }
                head1 = head1.next;
                head2 = head2.next;
            }
            if (count == count1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

