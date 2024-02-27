using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork27022024
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, f;
            double x, y;
            double opredelitel;
            double opredelitel_x;
            double opredelitel_y;

            while (true)
            {
                Console.WriteLine("Введите коэффициенты при х для квадратного уравнения:");

                if (!double.TryParse(Console.ReadLine(), out a) || a == 0)
                {
                    Console.WriteLine("Некорректное значение для a. Введите корректное значение.");
                    continue;
                }

                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Некорректное значение для b. Введите корректное значение.");
                    continue;
                }

                if (!double.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Некорректное значение для c. Введите корректное значение.");
                    continue;
                }

                if (!double.TryParse(Console.ReadLine(), out d))
                {
                    Console.WriteLine("Некорректное значение для d. Введите корректное значение.");
                    continue;
                }

                if (!double.TryParse(Console.ReadLine(), out e))
                {
                    Console.WriteLine("Некорректное значение для e. Введите корректное значение.");
                    continue;
                }

                if (!double.TryParse(Console.ReadLine(), out f))
                {
                    Console.WriteLine("Некорректное значение для f. Введите корректное значение.");
                    continue;
                }
                break;
            }
            Console.WriteLine($"Определитель = {opredelitel = a * e - b * d}");
            Console.WriteLine($"Определитель = {opredelitel_x = a * f - d * c}");
            Console.WriteLine($"Определитель = {opredelitel_y = b * f - e * c}");
            x = opredelitel_x / opredelitel;
            y = opredelitel_y / opredelitel;
            if (a != 0 && b != 0)
            {
                Console.WriteLine("Прямая общего положения");
                Console.WriteLine($"x2 = ");
            }
            if (a != 0 && b == 0 && c != 0)
            {
                Console.WriteLine("Прямая, параллельная ОУ");
                Console.WriteLine($"x1 = ");
            }
            if (a != 0 && b == 0 && c == 0)
            {
                Console.WriteLine("Ось ОУ");
                Console.WriteLine($"x2 = {-b / (2 * a)} - {Math.Sqrt(Math.Abs(D)) / (2 * a)}i");
            }

            if (a == 0 && b != 0 && c != 0)
            {
                Console.WriteLine("Прямая, параллельная ОХ");
                Console.WriteLine($"x2 = {-b / (2 * a)} - {Math.Sqrt(Math.Abs(D)) / (2 * a)}i");
            }

            if (a == 0 && b != 0 && c == 0)
            {
                Console.WriteLine("Ось ОХ");
                Console.WriteLine($"x2 = {-b / (2 * a)} - {Math.Sqrt(Math.Abs(D)) / (2 * a)}i");
            }

            if (a == 0 && b == 0)
            {
                Console.WriteLine("Множество точек плоскости");
                Console.WriteLine($"x2 = {-b / (2 * a)} - {Math.Sqrt(Math.Abs(D)) / (2 * a)}i");
            }

            Console.ReadKey();
        }
    }
}
