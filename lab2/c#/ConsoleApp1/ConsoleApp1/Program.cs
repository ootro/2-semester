//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyText t = new MyText();
            t.Add(new MyString("Рядок 1"));
            t.Add(new MyString("Рядок 2"));
            t.Add(new MyString("Рядок 3"));
            t.Add(new MyString("Рядок 4"));
            t.Add(new MyString("Рядок 5"));

            t.RemoveAt(2);



            Console.WriteLine("Пiнчук Артур, Варiант №5, IС-93");
            Console.WriteLine(t);
      
            t.Clear();
            Console.WriteLine("Текст очищено");
            Console.WriteLine(t);
        }
    }
}
