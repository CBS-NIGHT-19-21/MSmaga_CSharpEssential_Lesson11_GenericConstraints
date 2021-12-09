// Declare class Car Collection T type of class objects.
class CarCollection<T>
{   // Declare List of T type class objects.
    private List<T> _collection = new List<T>();

    // Declare access to items by indexer.
    public T this[int index] { get { return _collection[index]; } }

    // Declare public property - number of items of the Car Collection.
    public long Count { get { return _collection.Count; } }

    //Adds item into ar Collection.
    public void Add(T item)
    {
        _collection.Add(item);
    }

    //Clears - deletes all item of Car Collection.
    public void Clear()
    {
        _collection.Clear();
        Console.WriteLine("All items of the collection have been cleaned successfully!");
    }

}