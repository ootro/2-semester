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
            m_data = new List<MyString>();
        }

        public void Add(MyString input) //Додавання рядка до тексту
        {
            m_data.Add(input);
        }

        public void Remove(MyString input) //Видалення рядка з тексту
        {
            m_data.Remove(input);
        }
        public void RemoveAt(int index) 
        {
            m_data.RemoveAt(index);
        }

        public void Replace(int index, MyString input)
        {
            m_data[index] = input;
        }

        public void Clear() //Очищення тексту
        {
            m_data.Clear();
        }

      //  public void Counter()
        //{
          //  int[] a;
            //for (var i = 0; i < m_data.Count; i++)
              //  a.Add(m_data[i].Length);
           // return a.Max();

      //  }
        public int Size()
        {
            return m_data.Count;
        }
        public void Length()
        {
            for (var i = 0; i < m_data.Count; i++)
                return i.Length;
        }
            public override string ToString()
        {
            string output = "";
            foreach (var x in m_data)
                output += x.ToString() + '\n';
            return output;
        }
    }
}
