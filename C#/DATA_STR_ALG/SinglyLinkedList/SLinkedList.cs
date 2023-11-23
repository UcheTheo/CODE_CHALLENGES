using System.Reflection.Metadata.Ecma335;

namespace DATA_STR_ALG;
public class SLinkedList<T>
{
    private SNode<T> head;
    private int count;

    public SLinkedList()
    {
        this.head = null!;
        this.count = 0;
    }

    public SNode<T> Head
    {
        get { return this.head; }
    }
    public bool IsEmpty
    {
        get { return this.count == 0; }
    }

    public int Count
    {
        get { return this.count; }
    }

    public SNode<T> CreateNode(T data)
    {
        SNode<T> node = new SNode<T>(data, null!);
        return node;
    }

    public void PrintListData()
    {
        SNode<T> temp = this.head;
        while (temp != null)
        {
            Console.WriteLine(temp.Data);
            temp = temp.Next;
        }
    }

    public void PrintListDataReverse()
    {
        for (int i = Count - 1; i >= 0; i--)
            Console.WriteLine(this.Get(i).Data);
    }

    public void PrintListDataRecurRev(SNode<T> head)
    {
        if (head == null) return;
        PrintListDataRecurRev(head.Next);

        Console.WriteLine(head.Data);
    }

    public SNode<T> InsertAt(int index, T data)
    {
        if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));

        if (data == null) throw new ArgumentNullException(nameof(data));

        if (index > this.count) index = Count;

        SNode<T> temp = this.head;
        SNode<T> newNode = new SNode<T>(data, null!);

        if (this.IsEmpty || index == 0)
        {
            //this.head = new SNode<T>(data, this.head);
            newNode.Next = this.head;
            this.head = newNode;
        }
        else
        {
            for (int i = 0; i < index - 1; i++)
                temp = temp.Next;

            //temp.Next = new SNode<T>(data, temp.Next);
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }
        count++;

        return newNode;

    }

    public SNode<T> InsertEnd(T data)
    {
        return this.InsertAt(Count, data);
    }

    public SNode<T> InsertFirst(T data) 
    {
        return this.InsertAt(0, data);
    }

    public SNode<T> InsertAfter(SNode<T> newNode, string pos, SNode<T> node)
    {
        if (node == null) throw new ArgumentNullException(nameof(node));

        SNode<T> temp = this.head;
        int position = this.IndexOf(node);

        if (pos == "B") position--;

        if (pos != "A" && pos != "B")
        {
            Console.WriteLine("Please the Position must either be A (rep After) or B ( rep Before)");
            return null!;
        }

        if (pos == "B" && position + 1 == 0) //|| (position == 0 && pos == "B"))
        {
            newNode.Next = this.head;
            this.head = newNode;
        }
        else
        {
            for (int i = 0; i < position; i++)
                temp = temp.Next;

            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        count++;
        return newNode;
    }

    public SNode<T> RemoveAt(int index)
    {
        if (index < 0 || index >= this.count)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (this.IsEmpty) return null!;

        SNode<T> temp = this.head;
        SNode<T> node = temp;

        if (index == 0)
        {
            this.head = temp.Next;
        }
        else
        {
            for (int i = 0; i < index - 1; i++)
                temp = temp.Next;

            node = temp.Next;
            temp.Next = node.Next;

        }
        count --;
        return node;
    }

    public SNode<T> RemoveFirst()
    {
        return this.RemoveAt(0);
    }

    public SNode<T> RemoveEnd()
    {
        return this.RemoveAt(this.count - 1);
    }

    public bool Contains(SNode<T> node)
    {
        return this.IndexOf(node) != -1;
    }

    public SNode<T> Get(int index)
    {
        if (index < 0) throw new ArgumentOutOfRangeException("index" + index);

        if (this.IsEmpty) return null!;

        if (index > this.count) index = Count;

        SNode<T> temp = this.head;

        for (int i = 0; i < index; i++) temp = temp.Next;

        return temp;
    }

    public int IndexOf(SNode<T> node)
    {
        SNode<T> temp = this.head;

        for (int i = 0; i < this.count; i++)
        {

            if (temp.Equals(node)) return i;

            temp = temp.Next;
        }
        return -1;
    }

    public SNode<T> ReverseList()
    {
        SNode<T> curr = this.head;
        SNode<T> prev = null!;
        SNode<T> temp;

        while (curr != null)
        {
            temp = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = temp;
        }

        this.head = prev;
        return prev;
    }

    public SNode<T> ReverseListRecursive(SNode<T> head)
    {
        if (head == null) return null!;

        SNode<T> newHead = head;

        if (head.Next != null)
        {
            newHead = this.ReverseListRecursive(head.Next);
            head.Next.Next = head;
        }

        head.Next = null!;

        this.head = newHead;
        return newHead;
    }
}
