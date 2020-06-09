using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW4_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пінчук Артур, ІС-93");
            Console.WriteLine("Перший рядок: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Другий рядок: ");
            string str2 = Console.ReadLine();
            char[] arr1;
            char[] arr2;
            arr1 = str1.ToCharArray(); //переведення рядків у масиви символів
            arr2 = str2.ToCharArray();

            MyClass a = new MyClass(arr1); //створюємо об'єкти класу
            MyClass b = new MyClass(arr2);
            MyClass c = new MyClass(a + b);


            Console.WriteLine("Перший рядок: ");
            Console.WriteLine(a.getLine());

            Console.WriteLine("Довжина першого рядку: ");
            Console.WriteLine(a.getLength());

            a = a - '5';

            Console.WriteLine("Вилучаємо 5 з першого рядку: ");
            Console.WriteLine(a.getLine());

            Console.WriteLine("Третій рядок: ");
            Console.WriteLine(c.getLine());
        }
    }
}