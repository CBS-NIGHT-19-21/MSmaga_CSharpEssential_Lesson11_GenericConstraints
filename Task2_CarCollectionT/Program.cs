namespace Task2_CarCollectionT
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // Задание 2
            // Используя Visual Studio, создайте проект по шаблону Console Application. 
            // Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность 
            // использования его экземпляра для создания парка машин. Минимально требуемый интерфейс 
            // взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и 
            // года ее выпуска, индексатор для получения значения элемента по указанному индексу и свойство 
            // только для чтения для получения общего количества элементов. 
            // Создайте метод удаления всех машин автопарка.
            #endregion

            // Instance Car Class.
            Car myCar = new Car("Dodge", 2017);
            Car myWifeCar = new Car("BMWx6", 2020);
            Car myOldestSonCar = new Car("Toyota", 2018);
            Car myYoungerSonCar = new Car("Honda", 2019);

            // Instance Car Collection.
            CarCollection<Car> CarCollection = new CarCollection<Car>();

            // Add items (as instances of Car Class) into Car Collection.
            CarCollection.Add(myCar);
            CarCollection.Add(myWifeCar);
            CarCollection.Add(myOldestSonCar);
            CarCollection.Add(myYoungerSonCar);

            // Show item of Car Collection by index.
            Console.WriteLine($"My car is {CarCollection[0].Name} - {CarCollection[0].Year}");

            // Show all items of Car Collection by index.
            for (int i = 0; i < CarCollection.Count; i++)
            {
                Console.WriteLine($"Element of list {i}. {CarCollection[i].Name}\t -\t{CarCollection[i].Year}");
            }

            // Show number of items of Car Collection.
            Console.WriteLine($"Total items: {CarCollection.Count}");

            // Clear - delete all items of Car Collection.
            CarCollection.Clear();

            // Delay.
            Console.ReadLine();
        }
    }
}

