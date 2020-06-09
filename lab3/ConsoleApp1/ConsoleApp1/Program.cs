using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab03;



namespace Lab_03
{

    class Progra
    {

        static void Main()
        {

            Console.WriteLine("Input n:"); //введення розмірності масиву

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input m:");

            int m = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, m];



            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {

                    Console.Write("Arr[" + (i + 1) + "," + (j + 1) + "] = ");

                    arr[i, j] = Convert.ToInt32(Console.ReadLine());

                }

            }



            MatrixClass arr_temp = new MatrixClass(n, m, arr); //виклики класів

            Console.WriteLine("\nAdded elements value: ");

            Console.Write(arr_temp.adder);

            Console.WriteLine();

            Console.WriteLine("\nInput Index: ");

            int k = Convert.ToInt32(Console.ReadLine());

            double sum = arr_temp[k - 1];

            Console.Write("\nAvarage value: " + sum);

            Console.ReadKey();

        }

    }

}