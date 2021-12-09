using System.Collections;

namespace Task_Additional_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // Задание Дополнительное
            // Используя Visual Studio, создайте проект по шаблону Console Application. 
            // В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа,
            // переберите данную коллекцию с помощью, цикла for – С какой проблемой вы столкнулись?
            #endregion

            // Instance ArrayList.
            ArrayList myArrayList = new ArrayList();

            // Add various variables of value type.
            myArrayList.Add(13);
            myArrayList.Add(13.19m);
            myArrayList.Add(13.19d);

            MyStructure myStructureInstance = new MyStructure();
            myArrayList.Add(myStructureInstance.a);
            myArrayList.Add(myStructureInstance.b);

            // Add various variables of reference types.
            MyClass myClassInstance = new MyClass();
            myArrayList.Add(myClassInstance.ID);

            myArrayList.Add((object)14);
            myArrayList.Add("15,14");

            // Show all elements of ArrayList.
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine($"{ myArrayList[i] }\t-{ myArrayList[i]!.GetType() }");
            }

            // Delay.
            Console.ReadLine();

        }
    }
}


