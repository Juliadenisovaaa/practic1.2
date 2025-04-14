using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Входные данные
            double a = 3; // Длина первой стороны
            double b = 4; // Длина второй стороны
            double c = 5; // Длина третьей стороны

            // Проверка на существование треугольника
            bool isTriangle = (a + b > c) && (a + c > b) && (b + c > a) && (a > 0) && (b > 0) && (c > 0);

            // Вывод результата
            if (isTriangle)
            {
                Console.WriteLine("Является треугольником");
            }
            else
            {
                Console.WriteLine("Не является треугольником");
            }

        }
    }
}
