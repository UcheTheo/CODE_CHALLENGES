namespace DATA_STR_ALG.SinglyLinkedList;

public class SLinkInterview
{

    public SNode<T> ReverseSLinkedList<T>(SNode<T> head)
    {
        SNode<T> curr = head;
        SNode<T> prev = null!;
        SNode<T> temp;

        while (curr != null)
        {
            temp = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = temp;
        }
        head = prev;
        return head;
    }

    public SNode<int> PartialReverse(SNode<int> head, int left, int right)
    {
        SNode<int> dummy = new SNode<int>(0, head);

        SNode<int> leftPrev = dummy;
        SNode<int> curr = head;
        
        // 1) Reach node at position "left"
        for (int i = 0; i < left - 1; i++)
        {
            leftPrev = curr;
            curr = curr.Next;
        }

        // Now curr = "left", leftPrev = "node before left"
        // 2) Reverse from left to right
        SNode<int> prev = null!;
        SNode<int> temp = null!;
        for (int i = 0; i < (right - left + 1); i++)
        {
            temp = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = temp;
        }

        // 3) Update Pointers
        leftPrev.Next.Next = curr; // curr is "node after right"
        leftPrev.Next = prev;  // prev is "right"

        return dummy.Next;
    }

    public SNode<T> PartialReverse<T>(SNode<T> head, int left, int right)
    {
        SNode<T> curr = head;
        SNode<T> prevLeft = null!; // points to the node before "left"
        int pos;

        for (pos = 0; pos < left; pos++)
        {
            prevLeft = curr;
            curr = curr.Next;
        }

        SNode<T> newHead = curr; // pointer to the head of the reversed linkedlist
        SNode<T> nextRight; 
        SNode<T> headRight = null!; // Stores pointer to the tail of the reversed linked list


        for (int i = pos; i <= right; i++)
        {
            nextRight = curr.Next;
            curr.Next = headRight;
            headRight = curr;
            curr = nextRight;
        }

        if (prevLeft != null)
            prevLeft.Next = headRight;
        else
            head = headRight;

        newHead.Next = curr;

        return head;

    }

    public SNode<T> MergeTwoSortedLists<T>(SNode<T> head, SNode<T> nodeList1, SNode<T> nodeList2) where T:  IComparable<T>
    {
        //Please note that the head of the node <head> must be created as pointing to a new node already 
        //Before assigning to the head. I.e, Before  using this method, create a new head node as
        // SNode<T> head = new SNode<T>(T data, null);
        SNode<T> curr = head;

        while (nodeList1 != null && nodeList2 != null) 
        {
            if (nodeList1.Data.CompareTo(nodeList2.Data) < 0)
            {
                curr.Next = nodeList1;
                nodeList1 = nodeList1.Next;
            }
            else
            {
                curr.Next = nodeList2;
                nodeList2 = nodeList2.Next;
            }
            curr = curr.Next;

        }
        //curr.Next = nodeList1 != null ? nodeList1 : nodeList2;
        curr.Next = nodeList1 ?? nodeList2!;
        return head.Next;
    }

    public SNode<int> AddTwoNumbers(SNode<int> nodeList1, SNode<int> nodeList2)
    {
        SNode<int> head = new SNode<int>(0, null!);
        SNode<int> curr = head;
        int carry = 0;
        

        while (nodeList1 != null || nodeList2 != null || carry != 0)
        {
            int l1Data = nodeList1 != null ? nodeList1.Data : 0;
            int l2Data = nodeList2 != null ? nodeList2.Data : 0;
            int total = l1Data + l2Data + carry;

            curr.Next = new SNode<int>(total % 10, null!);
            carry = total / 10;

            nodeList1 = nodeList1 != null ? nodeList1.Next : null!;
            nodeList2 = nodeList2 != null ? nodeList2.Next : null!;

            curr = curr.Next;
        }
        return head.Next;
    }

    public void ReOrderList<T>(SNode<T> head)
    {
        SNode<T> slow = head, fast = head.Next;

        // Find the middle node
        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        // Reverse the second half of the list
        SNode<T> second = slow.Next, prev = null!;
        slow.Next = null!;
        
        while (second != null)
        {
            SNode<T> temp = second.Next;
            second.Next = prev;
            prev = second;
            second = temp;
        }

        // Merge Back the two halves in the order required
        SNode<T> firstHead = head, secondHead = prev;

        while (secondHead != null)
        {
            SNode<T> temp1 = firstHead.Next, temp2 = secondHead.Next;
            firstHead.Next = secondHead;
            secondHead.Next = temp1;
            firstHead = temp1;
            secondHead = temp2;
        }
    }

    public SNode<int> RemoveElementFromList(SNode<int> head, int data) 
    {
        SNode<int> dummy = new(0, head);
        SNode<int> prev = dummy, curr = head; 

        while (curr != null)
        {
            SNode<int> temp = curr.Next;

            if (curr.Data == data)
                prev.Next = temp;
            else prev = curr;

            curr = curr.Next;
        }
        return dummy.Next;
    }

    public Boolean isPalindrome(SNode<int> head)
    {
        SNode<int> slow = head, fast = head;

        //Find midle (slow)
        while (fast != null && fast.Next != null)
        {
            fast = fast.Next.Next;
            slow = slow.Next;
        }

        // Reverse second half
        SNode<int> prev = null!;
        while (slow != null)
        {
            SNode<int> temp = slow.Next;
            slow.Next = prev;
            prev = slow;
            slow = temp;
        }

        // Check palindrom
        SNode<int> left = head, right = prev;
        while (right != null)
        {
            if (left.Data != right.Data)
                return false;
            left = left.Next;
            right = right.Next;
        }
        return true;
    }
}
