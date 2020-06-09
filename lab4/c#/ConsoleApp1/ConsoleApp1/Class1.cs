using System;
using System.Collections.Generic;
using System.Text;

namespace LW4_CS
{
    class MyClass
    {
        private char[] str; //оголошуємо масив символів

        public MyClass() //базовий конструктор
        {

        }
        public MyClass(char[] str) //конструктор з параметром
        {
            this.str = str;
        }

        public MyClass(MyClass other) //конструктор копіювання
        {
            this.str = other.str;
        }

        public char[] getLine() //виведення масиву
        {
            return str;
        }

        public int getLength() //обчислення довжини масиву
        {
            return str.Length;
        }

        public int getSize(MyClass obj, char symbol)
        {
            int Size = obj.str.Length;
            for (int i = 0; i < obj.str.Length; i++)
                if (obj.str[i] == symbol)
                    Size = obj.str.Length - 1;
            return Size;
        }
        public static MyClass operator -(MyClass obj, char symbol) //перевантаження оператору -
        {
            MyClass a = new MyClass();
            int size = obj.getSize(obj, symbol);
            char[] tmp = new char[size];
            int k = 0;
            for (int i = 0; i < obj.str.Length; i++)
            {
                if (obj.str[i] != symbol)
                    tmp[i - k] = obj.str[i];
                else
                    k++;
            }
            a.str = tmp;
            return a;
        }

        public static MyClass operator +(MyClass obj1, MyClass obj2) //перевантаження оператору +
        {
            MyClass c = new MyClass();
            string txt1 = new string(obj1.str);
            string txt2 = new string(obj2.str);
            string result = Convert.ToString(Convert.ToInt32(txt1) + Convert.ToInt32(txt2));
            char[] arr;
            arr = result.ToCharArray();
            c.str = arr;
            return c;
        }
    }
}
