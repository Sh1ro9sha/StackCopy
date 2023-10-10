using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCopy
{
    public class LimitedStack<T>
    {
        private readonly int maxSize;
        private LinkedList<T> list;

        public bool IsEmpty => list.Count == 0;
        // Это свойство возвращает true, если стек пуст(количество элементов равно 0), и false в противном случае.
        public int Count => list.Count;
        // Это свойство возвращает текущее количество элементов в стеке, используя свойство Count объекта list.
        public LimitedStack(int maxSize)
        {
            this.maxSize = maxSize;
            list = new LinkedList<T>();
        }
      // Макс. размер стека и инициализирует поля maxSize и List
        public LimitedStack(LimitedStack<T> other)
        {
            maxSize = other.maxSize;
            list = new LinkedList<T>(other.list);
        }

        public void Push(T item) // Добавляет элемент на вершину стека и проверяет не достигнут макс. размер стека
        {
            if (list.Count == maxSize)
            {
                throw new InvalidOperationException("Stack is full");
            }

            list.AddLast(item);
        }

        public T Pop() // Метод Pop удаляет и возвращает элемент с вершины стека. Так же проверяет, является ли стек пустым
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T item = list.Last.Value;
            list.RemoveLast();
            return item;
        }
    }
}