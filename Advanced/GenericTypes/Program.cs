MyList<int> myList = new MyList<int>();
myList.Add(1);
myList.Add(2);
Console.WriteLine(myList.GetByIndex(1));

MyList<string> myList1 = new MyList<string>();
myList1.Add("Hello");
myList1.Add("World");
Console.WriteLine(myList1.GetByIndex(0));


public class MyList<T>
{
    public MyList(int initialCapacity = 4)
    {
        _items = new T[initialCapacity];
    }

    private T[] _items;
    private int _counter = 0;

    public void Add(T item)
    {
        if (_counter == _items.Length)
        {
            Array.Resize(ref _items, _items.Length * 2);
        }
        _items[_counter] = item;
        _counter++;
    }

    public T GetByIndex(int index)
    {
        if (index < 0 || index >= _counter)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
        return _items[index];
    }

    public int Count => _counter;
}