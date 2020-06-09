using System;
using MyStackNamespace;
using StringNamespace;

namespace laba8
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пiнчук Артур, IС-93");

            string str = "1231241sdvsc333"; //ініціалізуємо рядок
            //str = Console.ReadLine();

            

            Method.MethodDelegate d1 = new Method.MethodDelegate(Method.countDigits); //ініціалізуємо делегат
            int result = d1(str); //ініціалізуємо змінну, що містить результат виконання методу для введеного рядку
            Console.WriteLine("static: " + result);


            Str s = new Str(); //ініціалізуємо об'єкт класу Str
            Console.WriteLine("exemplar: " + s.countDigitsDynamic(str) + "\n"); //виведення результату екземплярної версії методу

            MyStack stackk = new MyStack(); //ініціалізація стеку
            stackk.Add(5); //додаємо елементи до стеку
            stackk.Add(3);
            stackk.Add(6);
            stackk.Remove(); //видаляемо верхній елемент
            stackk.Remove();
            stackk.Remove();

            
        }
    }
}
