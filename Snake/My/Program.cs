using System;
using System.Collections.Generic; //Необходимо для использования списков


namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 2, '*');
            p1.Draw();

            Point p2 = new Point(3, 4, '#');
            p2.Draw();

            Console.ReadLine();

            //Создание объекта класса лист (нумерованный)
            List<int> numList = new List<int>();

            //Добавление элементов в созданный объект
            numList.Add(5);
            numList.Add(1);
            numList.Add(2);

            //Запись элементов списка в переменные, используя порядковые номера
            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            Console.WriteLine(x);

        }
    }
}
