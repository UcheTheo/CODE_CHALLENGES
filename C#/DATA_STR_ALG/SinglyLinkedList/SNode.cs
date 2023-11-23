namespace DATA_STR_ALG;
public class SNode<T>
{
    private T data;
    private SNode<T> next;

    public SNode(T data, SNode<T> next)
    {
        this.data = data;
        this.next = next;
    }

    public T Data
    {
        get { return this.data; }
        set { this.data = value; }
    }

    public SNode<T> Next
    {
        get { return this.next; }
        set { this.next = value; }
    }
}
