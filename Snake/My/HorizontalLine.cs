using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym) //Создание конструктора для горизонтальной линии
        {
            pList = new List<Point>(); // Создание пустого списка
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym); //Создание объекта класса Точка
                pList.Add(p);//Добавление объектов класса Точка в объект класса Лист
            }
        }
    }
}
