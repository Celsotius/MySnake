using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{/*
  * Принцип ООП Абстрагирование
  * WIKI: Абстракция служит для выделения в моделируемом предмете важного
  * для решения конкретной задачи по предмету,
  * в конечном счёте — контекстное понимание предмета,
  * формализуемое в виде класса.
  * 
  * Способ выделить набор значимых характеристик объекта, избегая незначимых
  * 
  */
    class Snake : Figure
    {
        // Определение переменных на уровне класса, для обеспечения доступности в различных методах
        Direction direction;
        int NumOfEdge; // В переменную записывается числовое значение символа границы

        public Snake(Point tail, int length, Direction direction)
        {
            //Конструктор класса Snake
            this.direction = direction;

            for (int i = 0; i < length; i++)
            {
                //Создание экземпляра класса точка, представляющего хвост змейки
                Point p = new Point(tail);
                //Перемещение точки на некоторое расстояние i
                p.Clone(i, direction);
                //Запись перемещенной точки в список
                pList.Add(p);
            }
        }
        public void Move()
        {
            //Метод обеспечивает перемещение Змейки на один символ. Сылается на метод CraeteNewHead()

            Point head = CraeteNextPoint();
            pList.Add(head); // Добавить точку в конец списка - создать голову
            head.Draw(); // Отрисовать новую голову
            

            Point tail = pList[0]; // Узнать параметры хвоста
            tail.Clear(); // Затереть старый хвост
            pList.Remove(tail); // Удалить старый хвост
        }

        public Point CraeteNextPoint()
        {
            //Вспомогательный метод для Move(). Создает следующую точку при перемещении змейки

            int last = pList.Count - 1; // Узнать номер последнего экземпляра в списке
            Point head = pList[last]; // Записать последний экземпляр из списка
            Point NewHead = new Point(head); // Создать новый экземпляр типа Point
            NewHead.Clone(1, direction); // В зависимости от направления изменить координату точки

            return NewHead;
        }

        public void ChangeDir(ConsoleKey key)
        {
            // Метод обеспечивает изменение направления движения змейки

            if (key == ConsoleKey.RightArrow) direction = Direction.RIGHT;
            else if (key == ConsoleKey.LeftArrow) direction = Direction.LEFT;
            else if (key == ConsoleKey.UpArrow) direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow) direction = Direction.DOWN;

        }
        
        // Обработка столкновения с границей
        // Метод возвращает 1, если есть столкновение и 0, если солкновения нет
        public bool IsKnock()
        {
            // Получить текущую координату головы и направление
            Point NewPoint = CraeteNextPoint(); // Создать точку перед змейкой
            bool knock = false;
            try
            {
                // Поставить курсор в точку перед змейкой
                Console.SetCursorPosition(NewPoint.x, NewPoint.y);
            }

            catch
            {
                // Обработать исключение System.ArgumentOutOfRangeException
                knock = true;
            }

            finally
            {
                // Если столкновения не произошло
            }

            return knock;

        }
        
        
    }
}
 