using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yUp, int yDown, char sym)
        {
            pList = new List<Point>(); //Использование объекта класса список для создания пустого списка
            for(int y = yUp; y <= yDown; y++)//Создание линии "точка за точкой"
            {
                Point p = new Point(x, y, sym);//Создание точки
                pList.Add(p);//Запись точки в список
            }
        }
    }
}
