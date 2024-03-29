﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int x, int y, char sym) //Конструктор класса вызываемый, при вызове формата Point p = new Point(arg1, arg2, arg3)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p) //Конструктор класса вызываемый при вызове формата Point p = new Point(arg1)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

       //Метод для сдвигания точки в заданном направлении
       public void Clone(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT) x += offset;
            else if (direction == Direction.LEFT) x -= offset;
            else if (direction == Direction.DOWN) y += offset;
            else if (direction == Direction.UP) y -= offset;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
        public void Clear()
        {
            sym = ' '; // Заменить первый объект
            Draw(); // Отрисовать новый хвост
        }

    }
}
