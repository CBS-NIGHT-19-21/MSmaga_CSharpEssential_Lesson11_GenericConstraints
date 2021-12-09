using System.Collections.Generic;

// Declare class MyDictionary<TKey, TValue> with various data type of its elements.
class MyDictionary<TKey, TValue> where TKey : notnull
{
    // Private field - Dictionary its elements.
    private Dictionary<TKey, TValue> _myDictionary;

    // Declare constructor class Dictionary<TKey, TValue>.
    public MyDictionary()
    {
        _myDictionary = new Dictionary<TKey, TValue>();
    }

    // Declare public attribute of the class - number of elements.
    public long Count { get { return _myDictionary.Count(); } }

    // Declare public attribute Indexer.
    public TValue this[TKey key] { get { return _myDictionary[key]; } }

    /// <summary>
    /// Adds new item to MyDictionary.
    /// </summary>
    /// <param name="item"></param>
    public void Add(TKey key, TValue value)
    {
        _myDictionary.Add(key, value);
    }
    
    /// <summary>
    /// Shows all items.
    /// </summary>
    public void Show()
    {
        foreach (KeyValuePair<TKey, TValue> keyValue in _myDictionary)
        {
            Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
        }
    }

}
