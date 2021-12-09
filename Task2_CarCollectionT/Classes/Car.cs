
// Declare class Car.
class Car
{
    // Declare private fields of instance of Car Class by default value.
    private string _name = "None";
    private int _year = 1900;

    // Declare public Properties of instance of Car Class.
    public string Name { get { return _name; } set { _name = value; } }
    public int Year { get { return _year; } set { _year = value; } }

    // Declare constructor of object of the Car Class.
    public Car(string name, int year)
    {
        _name = name;
        _year = year;
    }
}