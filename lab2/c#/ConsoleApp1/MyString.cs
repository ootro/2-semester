using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public class MyString
    {
        private char[] m_data;
        public MyString(string input = "")
        {
            m_data = input.ToCharArray();
           
        }
        public override string ToString()
        {
            return new string(m_data);
        }
    }
}
