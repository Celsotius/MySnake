using System;
using System.Collections.Generic; //Необходимо для использования списков


namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int AreaLength = 20;
            string lvlName = "LEVEL 1";

            HorizontalLine UpLine = new HorizontalLine(0, AreaLength, 0, '-'); //Создание объекта класса UЛиния
            UpLine.Draw();

            HorizontalLine DownLine = new HorizontalLine(0, AreaLength, 10, '-'); //Создание объекта класса Линия
            DownLine.Draw();

            VerticalLine LeftLine = new VerticalLine(0, 1, 9, '|');
            LeftLine.Draw();

            VerticalLine RightLine = new VerticalLine(AreaLength, 1, 9, '|');
            RightLine.Draw();

            //Напись ЛВЛ
            //Console.SetCursorPosition(7, 5);
            //Console.WriteLine(lvlName);
            //Убрать надпись

            //Отрисовка змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();

            Console.ReadLine();
        }
    }
}
