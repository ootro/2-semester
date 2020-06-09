namespace StringNamespace
{
    public class Str
    {
        public int countDigitsDynamic(string _string)
        {
            int count = 0;
            int i = 0;
            while (i < _string.Length)
            {
                if (_string[i] >= '0' && _string[i] <= '9')
                    count++;
                i++;
            }
            return count;
        }

        
        
    }
    public class Method //клас, що містить статичну версію методу визначення кількості цифр у рядку
    {

        internal static int countDigits(string string_name) //метод визначення кількості цифр у рядку
        {
            int count = 0;
            int i = 0;
            int l = string_name.Length;
            while (i < l)
            {
                if (string_name[i] >= '0' && string_name[i] <= '9')
                {
                    count++;
                }
                i++;
            }
            return count;
        }



        public delegate int MethodDelegate(string string_name); //оголошуємо делегат


    }
}
