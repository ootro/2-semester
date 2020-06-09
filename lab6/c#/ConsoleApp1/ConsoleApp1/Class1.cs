using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Expression
    {
        private float a, c, d;

        public Expression()
        {
            a = 0;
            c = 0;
            d = 1;
        }
        public Expression(float a, float c, float d)
        {
            this.a = a;
            this.c = c;
            this.d = d;
        }
        public double getResult()
        {
            if (d <= 0)
                throw new Exception("d<=0\n");
            if (c + a == 1)
                throw new Exception("c+a=1\n");
            return (2 * c - d * Math.Sqrt(42 / d)) / (c + a - 1);
        }

        public static Expression operator +(Expression obj1, Expression obj2)
        {
            return new Expression(obj1.a + obj2.a, obj1.c + obj2.c, obj1.d + obj2.d);
        }

        public static Expression operator -(Expression obj1, Expression obj2)
        {
            return new Expression(obj1.a - obj2.a, obj1.c - obj2.c, obj1.d - obj2.d);
        }

        public static Expression operator *(Expression obj1, Expression obj2)
        {
            return new Expression(obj1.a * obj2.a, obj1.c * obj2.c, obj1.d * obj2.d);
        }

        public static Expression operator /(Expression obj1, Expression obj2)
        {
            if (obj2.a == 0 || obj2.c == 0 || obj2.d == 0)
                throw new Exception("Division by zero\n");
            return new Expression(obj1.a / obj2.a, obj1.c / obj2.c, obj1.d / obj2.d);
        }
    }
}
