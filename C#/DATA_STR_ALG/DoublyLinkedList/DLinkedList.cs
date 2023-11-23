namespace DATA_STR_ALG;
public class DLinkedList<T>
{
    private DNode<T> head;
    int count;

    public DLinkedList()
    {
        this.head = null!;
        this.count = 0;
    }

    public DNode<T> Head
    { 
        get { return this.head; } 
    }

    public bool IsEmpty
    {
        get { return this.head == null; }
    }

    public int Count
    {
        get { return this.count; }
    }

    public DNode<T> CreateNode(T data)
    {
        return new DNode<T>(data);
    }

    public void PrintListData()
    {
        if (this.head != null) return;

        while (this.head != null) 
        {
            Console.WriteLine("Data: {0}", this.head.Data);
            this.head = this.head.Next;
        }
    }

    public void PrintListDataReverse()
    {
        if (this.head != null) return;

        DNode<T> curr = this.head!;

        while (curr.Next != null) 
            curr = curr.Next;

        while (curr != null) 
        {
            Console.WriteLine("Data: {0}", curr.Data);
            curr = curr.Prev;
        }
    }

    public DNode<T> InsertAt(int index, T data)
    {
        if (index < 0)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (index > this.Count)
            index = this.Count;

        if (data == null)
            throw new ArgumentNullException(nameof(data));

        DNode<T> curr = this.head;
        DNode<T> temp = null!;
        DNode<T> newNode = new DNode<T>(data);

        if (index  == 0)
        {
            newNode.Next = this.head;

            if (this.head != null)
                this.head.Prev = newNode;

            this.head = newNode;
        }
        else
        {
            for (int i = 0; i < index - 1; i++)
                curr = curr.Next;

            temp = curr.Next;
            curr.Next = newNode;
            newNode.Prev = curr;
            newNode.Next = temp;

            if (temp != null)
                temp.Prev = newNode;
        }
        count++;
        return newNode;
    }
}
