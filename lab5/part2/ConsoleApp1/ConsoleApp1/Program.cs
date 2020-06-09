using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW5._2
{
    class Program
    {
        abstract class Figure //абстрактний клас Фігура
        {
            public abstract double getSquare();
            public abstract double getArea();
        }

        class Circle : Figure //похідний клас Коло
        {
            private double radius;

            public Circle(float radius) //конструктор з вказівником
            {
                this.radius = radius;
            }

            public override double getArea() //метод знаходження довжини Кола
            {
                return 2 * Math.PI * radius;
            }

            public override double getSquare() //метод знаходження площі Кола
            {
                return Math.PI * Math.Sqrt(radius);
            }

            class Elipse : Figure //похідний клас Еліпс
            {
                private double a, b;

                public Elipse(double a, double b) //конструктор з вказівниками
                {
                    this.a = a;
                    this.b = b;
                }

                public override double getArea()
                {
                    return Math.PI * (a + b);
                }

                public override double getSquare()
                {
                    return Math.PI * a * b;
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Пiнчук Артур, IС-93");
                Elipse a = new Elipse(4, 5);
                Circle b = new Circle(5);

                Console.WriteLine(a.getArea());
                Console.WriteLine(a.getSquare());

                Console.WriteLine(b.getArea());
                Console.WriteLine(b.getSquare());
            }
        }
    }
}