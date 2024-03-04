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

                if (!double.TryParse(Console.ReadLine(), out a))
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
            Console.WriteLine($"Определитель x = {opredelitel_x = c * e - f * b}");
            Console.WriteLine($"Определитель y = {opredelitel_y = a * f - c * d}");
            x = opredelitel_x / opredelitel;
            y = opredelitel_y / opredelitel;

            if (opredelitel != 0)
            {
                x = opredelitel_x / opredelitel;
                y = opredelitel_y / opredelitel;
                Console.WriteLine($"Прямые пересекаются в точке с координатами: ({x}, {y})");
            }
            else
            {
                if (opredelitel_x == 0 && opredelitel_y == 0)
                {
                    x = 1;

                    if (b == 0)
                    {
                        y = 0;
                    }
                    else
                    {
                        y = (c - a) / b;
                    }

                    Console.WriteLine($"Уравнение имеет множество решений. Одно из решений, где прямые пересекаются в точке с координатами: ({x}, {y})");
                }
                else
                {
                    Console.WriteLine("Система не имеет решений");
                }
            }

            if (a != 0 && b != 0)
            {
                Console.WriteLine("Первая прямая общего положения");             
            }
            if (a != 0 && b == 0 && c != 0)
            {
                Console.WriteLine("Первая прямая, параллельная ОУ");                
            }
            if (a != 0 && b == 0 && c == 0)
            {
                Console.WriteLine("Первая ось ОУ");
            }

            if (a == 0 && b != 0 && c != 0)
            {
                Console.WriteLine("Первая прямая, параллельная ОХ");
            }

            if (a == 0 && b != 0 && c == 0)
            {
                Console.WriteLine("Первая ось ОХ");            
            }

            if (a == 0 && b == 0)
            {
                Console.WriteLine("Первая прямая - множество точек плоскости");             
            }


            if (d != 0 && e != 0)
            {
                Console.WriteLine("Вторая прямая общего положения");
            }
            if (d != 0 && e == 0 && f != 0)
            {
                Console.WriteLine("Вторая прямая, параллельная ОУ");
            }
            if (d != 0 && e == 0 && f == 0)
            {
                Console.WriteLine("Вторая ось ОУ");
            }

            if (d == 0 && e != 0 && f != 0)
            {
                Console.WriteLine("Вторая прямая, параллельная ОХ");
            }

            if (d == 0 && e != 0 && f == 0)
            {
                Console.WriteLine("Прямая ось ОХ");
            }

            if (d == 0 && e == 0)
            {
                Console.WriteLine("Вторая прямая - множество точек плоскости");
            }

            Console.ReadKey();
        }
    }
}
