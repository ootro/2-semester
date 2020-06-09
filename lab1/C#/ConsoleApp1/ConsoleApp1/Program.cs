using System;

namespace laba1
{
    class Program
    {
        public static void Increase(ref int x)
        {
            int bit = 1, counter = 0;
            while (bit != 0)
            {
                bit = (x >> counter) & 1;
                x ^= 1 << counter;
                counter++;
            }
        }

        public static int Compare(int a, int b)
        {
            int bitA, bitB;
            for (int i = 0; i <= 31; i++)
            {
                bitA = (a >> i) & 1;
                bitB = (b >> i) & 1;
                if (bitA != bitB)
                    return 0;
            }
            return 1;
        }
        static void Main()
        {
            Console.WriteLine("Роботу виконав студент групи IС-93 факультету iнформатики та обчислювальної технiки Пiнчук Артур");
            int a = 63, b = -18, c = 92;
            Increase(ref a);
            Console.WriteLine(a);
            Console.WriteLine();
            Console.WriteLine(Compare(b, c));
            Console.ReadKey();
        }
    }
}
