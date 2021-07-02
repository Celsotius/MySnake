using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{/*Наследование
  
  */
    class Figure
    {
        protected List<Point> pList = new List<Point>(); //Создание объекта класса Список. Доступный для производных классов

        //Создание метода для отображения линии
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw(); //Вызов метода из класса Точка
            }
        }
    }
}

