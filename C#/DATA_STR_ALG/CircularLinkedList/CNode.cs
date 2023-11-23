namespace DATA_STR_ALG.CircularLinkedList;

public class CNode<T>
{
    private T _data;
    private CNode<T> _next;

    public CNode(T data, CNode<T> next)
    {
        _data = data;
        _next = next;
    }

    public T Data {
        get{ return _data; }
        set { _data = value; }
    }

    public CNode<T> Next 
    { 
        get { return _next; } 
        set { _next = value; }
    }
}
