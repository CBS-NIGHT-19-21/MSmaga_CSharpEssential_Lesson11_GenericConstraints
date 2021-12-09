using System.Collections;

// Declare class MyArrayList.
class MyArrayList<T>
{   // Declare field as ArrayList from System.Collections.
    private  ArrayList _myArrayList;

    // Declare Property - number of items.
    public long Count { get { return _myArrayList.Count;} }

    // Declare constructor of MyArrayList.
    public MyArrayList()
    {
        _myArrayList = new ArrayList();
    }

    // Access property as indexer of the items.
    public object this [int index] 
    { get 
        { if (index < _myArrayList.Count)
            { 
                return _myArrayList[index]!; 
            }
            else return 0;
        } 
    }

    /// <summary>
    /// Adds a new item.
    /// </summary>
    /// <param name="item"></param>
    public void Add(T item)
    {
        _myArrayList.Add(item);
    }

    /// <summary>
    /// Shows all items of MyArrayList
    /// </summary>
    public void Show()
    {
        foreach (T item in _myArrayList)
        {
            Console.WriteLine($"{item}");
        }
    }
}