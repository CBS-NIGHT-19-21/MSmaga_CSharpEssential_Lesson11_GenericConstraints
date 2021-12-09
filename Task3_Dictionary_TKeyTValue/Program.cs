namespace Task3_Dictionary_TKeyTValue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 3
            // Задание 3
            // Используя Visual Studio, создайте проект по шаблону Console Application. 
            // Создайте класс Dictionary<TKey, TValue>. Реализуйте в простейшем приближении возможность 
            // использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен 
            // System.Collections.Generic. Минимально требуемый интерфейс взаимодействия с экземпляром,
            // должен включать метод добавления пар элементов, индексатор для получения значения элемента по 
            // указанному индексу и свойство только для чтения для получения общего количества пар элементов.
            #endregion

            // Instance class myDictionary.
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            // Call method to add into list.
            myDictionary.Add(1, "Hi");
            myDictionary.Add(2, "there");
            myDictionary.Add(3, "!");

            // Show all items.
            myDictionary.Show();
            // Show item by index.
            Console.WriteLine(myDictionary[2]);

            // Delay.
            Console.ReadLine();


        }
    }
}

