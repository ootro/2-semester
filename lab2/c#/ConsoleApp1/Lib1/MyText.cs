using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public class MyText
    {
        private List<MyString> m_data;
        public MyText()
        {
            m_data = new List<MyString>(); //створення тексту з введених рядків
        }

        public void Add(MyString input) //Додавання рядка до тексту
        {
            m_data.Add(input);
        }

        public void RemoveAt(int index)  //Видалення рядка з тексту
        {
            m_data.RemoveAt(index);
        }


        public void Clear() //Очищення тексту
        {
            m_data.Clear();
        }

    
   
            public override string ToString() //модифікатор для виведення тексту порядково
        {
            string output = ""; //значення для виведення
            foreach (var x in m_data) //цикл
                output += x.ToString() + '\n'; //додавання кожного рядку тексту до виведення
            return output;
        }
    }
}
