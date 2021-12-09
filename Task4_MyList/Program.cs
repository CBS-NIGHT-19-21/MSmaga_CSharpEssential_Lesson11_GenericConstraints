namespace Task4_MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 4
            //Используя Visual Studio, создайте проект по шаблону Console Application. 
            //Создайте класс ArrayList. Реализуйте в простейшем приближении возможность использования его 
            //экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections. 
            #endregion

            // Declare instance MyArrayList
            MyArrayList<String> list = new MyArrayList<string>();

            // Add items.
            list.Add("Hi");
            list.Add(",");
            list.Add("There");
            list.Add("!!!");

            // Show all items.
            list.Show();

            // Show item by index.
            Console.WriteLine(list[3]);
            // Show item what does not exist.
            Console.WriteLine(list[13]);

            // Delay.
            Console.ReadLine();
        }
    }
}

