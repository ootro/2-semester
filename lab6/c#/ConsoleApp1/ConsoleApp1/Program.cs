using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пінчук Артур, ІС-93");

            const int size = 6;
            int i = 0;
            Expression[] arr = new Expression[size];

            arr[0] = new Expression(1, 3, 42);
            arr[1] = new Expression(2, -1, 36);
            arr[2] = arr[0] - arr[1];
            arr[3] = arr[1] + arr[2];
            arr[4] = arr[2] * arr[3];
            try
            {
                arr[5] = arr[3] / arr[4];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            while (i < size)
            {
                try
                {
                    for (; i < size; i++)
                        Console.WriteLine($"arr[{i}] = {arr[i].getResult()}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                i++;
            }
        }
    }
}