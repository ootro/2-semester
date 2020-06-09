using System;
using System.Collections.Generic;

namespace MyStackNamespace
{
    class MyStack //клас стеку
    {
        private static Stack<int> _stack = new Stack<int>(); //ініціалізація стеку
        private delegate void checkClear(); //оголошення делегату
        private static event checkClear Check; //оголошення події

        public MyStack() //конструктор, що викликає подію як тільки стек повністю очиститься 
        {
            Check = ifEmpty;
        }

        public void ifEmpty() //функція для перевірки пустоти стеку
        {
            if (_stack.Count == 0)
                Console.WriteLine("The stack is empty");
        }

        public void Add(int a) //функція для додавання елементів до стеку
        {
            _stack.Push(a);
            Console.WriteLine("Stack element " + a + " was added");
        }

        public void Remove() //функція для видалення елементів з стеку
        {
            int stackElement = _stack.Pop();
            Console.WriteLine("Stack element " + stackElement + " was removed");
            Check();
        }
    }
}
