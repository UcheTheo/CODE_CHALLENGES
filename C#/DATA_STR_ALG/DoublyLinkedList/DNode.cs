namespace DATA_STR_ALG;
public class DNode<T>
{
    private T data;
    private DNode<T> next;
    private DNode<T> prev;

    public DNode( T data, DNode<T> prev = null!, DNode<T> next = null!)
    {
        this.data = data;
        this.next = next;
        this.prev = prev;
    }

    public T Data
    {
        get { return data; }
        set { data = value; }
    }

    public DNode<T> Next
    {
        get { return next; }
        set { next = value; }
    }

    public DNode<T> Prev
    {
        get { return prev; }
        set { prev = value; }
    }
}
