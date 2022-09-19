// 12. Найти значение функции y =  4*(x-3)^6 - 7*(x-3)^3 + 2

using System;

namespace DZ_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для функции:          y =  4*(x-3)^6 - 7*(x-3)^3 + 2 ");
            Console.Write("Введите значение:     x =  ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Значение функции:     y =  { 4 * Math.Pow(x - 3, 6) - 7 * Math.Pow(x - 3, 2) + 2 }");
        }
    }
}

