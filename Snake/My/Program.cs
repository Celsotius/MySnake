using System;
using System.Collections.Generic; //Необходимо для использования списков
using System.Threading; //Необходимо для использования задержки

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int AreaLength = 40;
            int AreaHeigth = 20;
            string lvlName = "LEVEL 1";

            HorizontalLine UpLine = new HorizontalLine(0, AreaLength, 0, '-'); //Создание объекта класса UЛиния
            UpLine.Draw();

            HorizontalLine DownLine = new HorizontalLine(0, AreaLength, AreaHeigth, '-'); //Создание объекта класса Линия
            DownLine.Draw();

            VerticalLine LeftLine = new VerticalLine(0, 1, AreaHeigth-1, '|');
            LeftLine.Draw();

            VerticalLine RightLine = new VerticalLine(AreaLength, 1, AreaHeigth-1, '|');
            RightLine.Draw();

            //Напись ЛВЛ
            //Console.SetCursorPosition(7, 5);
            //Console.WriteLine(lvlName);
            //Убрать надпись

            //Отрисовка змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            // Цикл обеспечивает дивжение змейки, вызывая метод Move с задержкой
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    // Получить значение нажатой клавиши и записать в "состояние" key
                    ConsoleKeyInfo key = Console.ReadKey();

                    // Обращение к методу в экземпляре snake.
                    // Метод получает нажатую клавишу и меняет направление движения змейки.
                    snake.ChangeDir(key.Key);
                }
                Thread.Sleep(100); //Задержка
                snake.Move(); //Движение
            }
        }
    }
}
