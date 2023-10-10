using System;

namespace StackCopy;
class Program
{
    static void Main()
    {
        Console.Write("Введите размер стека:");
        int size = int.Parse(Console.ReadLine());
        int count = 0; // отслеживание кол-ва элементов в стеке
        LimitedStack<int> stack = new LimitedStack<int>(size);
        string input = null;
        bool overflow = true; // контроль выполнения цикла
        while (overflow)
        {
            if (count < size)
            {
                Console.Write("Введите элемент: ");
                input = Console.ReadLine();
                int item = int.Parse(input);
                stack.Push(item);
                count++;
            }
            LimitedStack<int> copiedStack = new LimitedStack<int>(stack);
            if (count >= size)
            {
                while (!stack.IsEmpty)
                {
                    Console.Write(stack.Pop());
                }
                overflow = false;
                Console.WriteLine("\ncopy");
                while (!copiedStack.IsEmpty)
                {
                    Console.Write(copiedStack.Pop());
                }
            }
        }
    }
}