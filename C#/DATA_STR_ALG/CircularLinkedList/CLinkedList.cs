namespace DATA_STR_ALG.CircularLinkedList;

public class CLinkedList<T>
{
    private CNode<T> _head;
    private CNode<T> _tail;

    public CLinkedList()
    {
        _head = null!;
        _tail = null!;
    }

    public CNode<T> Head
    { 
        get { return _head; } 
    }

    public CNode<T> Tail
    { 
        get { return _tail; } 
    }

    public bool IsEmpty()
    { 
        return _head == null; 
    }

    public void PrintList()
    {
        if(_head == null) return;

        CNode<T> temp = _head;
        while (temp.Next != _head)
        {
            Console.Write("{0} ", temp.Data);
            temp = temp.Next;
        }
        Console.WriteLine("{0} ", temp.Data);
    }

    public void PushEnd(T data)
    {
        CNode<T> newNode = new(data, null!);
        CNode<T> temp = _head;

        if ( IsEmpty())
        {
            _head = newNode;
        }
        else
        {
            while (temp.Next != null && temp.Next != _head)
                temp = temp.Next;

            temp.Next = newNode;
        }

        newNode.Next = _head;
    }

    public void PopEnd()
    {
        CNode<T> temp = _head, temp2 = null!;

        if (IsEmpty())
        {
            Console.WriteLine("No item in the list");
            return;
        }

        while (temp.Next != null && temp.Next != _head)
        {
            temp2 = temp;
            temp = temp.Next;
        }

        temp2.Next = _head;
        temp.Next = null!;

    }

    public void PushEnd2(T data)
    {
        CNode<T> newNode = new(data, null!);

        if (IsEmpty())
        {
           _tail = _head = newNode;
        }
        else
        {
            _tail.Next = newNode;
            _tail = newNode;
        }
        _tail.Next = _head;
    }

    public void PushStart(T data)
    {
        CNode<T> newNode = new(data, null!);
        CNode<T> temp = _head;

        if (IsEmpty())
        {
            _head = newNode;
        }
        else
        {
            while (temp.Next != null && temp.Next != _head)
                temp = temp.Next;

            temp.Next = newNode;
        }

        newNode.Next = _head;
        _head = newNode;
    }

    public void PushStart2(T data)
    {
        CNode<T> newNode = new(data, null!);

        if (IsEmpty())
        {
            _tail = _head = newNode;
        }
        else
        {
           newNode.Next = _head;
            _head = newNode;
        }
        _tail.Next = _head;
    }

}
