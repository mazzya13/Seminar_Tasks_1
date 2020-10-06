using System;

namespace Seminar_Tasks_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Expr1();
            Expr2();
            Expr3();
            Expr4();
            Expr5();
        }
        static void Expr1()
        {
            //Expr1. Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?

            int a = 22;
            int b = 89;
            a += b;
            b -= a;
            b = -b;
            a -= b;
            Console.WriteLine($"Expr1: {a}, {b}");

            //Не стоит, тк это усложняет чтение кода.
        }
        static void Expr2()
        {
            /*Expr2. Задается натуральное трехзначное число (гарантируется, что трехзначное). 
             *Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
             */

            int a = 123;
            int ed = a % 10;
            int sot = a / 100;
            a = a - (sot * 100) - ed;
            a = a + ed * 100 + sot;
            Console.WriteLine($"\nExpr2: {a}");
        }
        static void Expr3()
        {
            /*Expr3.Задано время Н часов(ровно). 
             *Вычислить угол в градусах между часовой и минутной стрелками.Например, 5 часов-> 150 градусов, 20 часов-> 120 градусов.
             *Не использовать циклы.
             */

            int H = 20;
            var angle = Math.Abs(H % 12 * 30 - (H % 12) / 6 * 360);
            Console.WriteLine($"\nExpr3: {angle}");
        }
        static void Expr4()
        {
            //Expr4. Найти количество чисел меньших N, которые имеют простые делители X или Y.

            int N = 40;
            int X = 2;
            int Y = 5;
            Console.Write($"\nExpr4:");
            for (int i = 1; i <= N; i++)
            {
                if (i % X == 0 && i % Y == 0)
                    Console.Write($" {i}");
            }
        }
        static void Expr5()
        {
            //Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.

            int a = 2000;
            int b = 2024;
            var ya = new DateTime(a, 1, 1);
            var yb = new DateTime(b, 1, 1);
            var nonLeapDays = 365 * (b - a);
            var leapDays = (yb - ya).Days - nonLeapDays;
            Console.WriteLine($"\n\nExpr5: {leapDays}");
        }
    }
}
