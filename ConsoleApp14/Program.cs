using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void task1()
        {
            int num1 = 5;
            int num2 = 10;
            int num3 = 21;

            Console.WriteLine($"{num1}  {num2}  {num3}");
        }

        static void task2()
        {
            {
                Console.WriteLine(5);
                Console.WriteLine(10);
                Console.WriteLine(21);
            }
        }

        static void task3()
        {
            int centimeters = 345; // Замените на нужное значение
            int meters = centimeters / 100;
            Console.WriteLine($"Число полных метров: {meters}");
        }

        static void task4()
        {
            int days = 234; // Замените на нужное значение
            int weeks = days / 7;
            Console.WriteLine($"Число полных недель: {weeks}");
        }

        static void task5()
        {
            int number = 58; // Замените на нужное значение
            int tens = number / 10;
            int units = number % 10;
            int sum = tens + units;
            int product = tens * units;
            Console.WriteLine($"Десятки: {tens}");
            Console.WriteLine($"Единицы: {units}");
            Console.WriteLine($"Сумма цифр: {sum}");
            Console.WriteLine($"Произведение цифр: {product}");
        }

        static void task6()
        {
            bool A = true;
            bool B = false;
            bool C = false;

            Console.WriteLine($"A или B: {A || B}");
            Console.WriteLine($"A и B: {A && B}");
            Console.WriteLine($"B или C: {B || C}");
        }

        static void task7()
        {
            double radius = 5.0; // Замените на радиус круга
            double side = 4.0;   // Замените на длину стороны квадрата

            double circleArea = Math.PI * radius * radius;
            double squareArea = side * side;

            if (circleArea > squareArea)
            {
                Console.WriteLine("Площадь круга больше.");
            }
            else if (circleArea < squareArea)
            {
                Console.WriteLine("Площадь квадрата больше.");
            }
            else
            {
                Console.WriteLine("Площади равны.");
            }
        }

        static void task8()
        {
            double volume1 = 1000; // Замените на объем первого тела
            double mass1 = 1500;  // Замените на массу первого тела

            double volume2 = 800;  // Замените на объем второго тела
            double mass2 = 1200;  // Замените на массу второго тела

            double density1 = mass1 / volume1;
            double density2 = mass2 / volume2;

            if (density1 > density2)
            {
                Console.WriteLine("Плотность первого тела больше.");
            }
            else if (density1 < density2)
            {
                Console.WriteLine("Плотность второго тела больше.");
            }
            else
            {
                Console.WriteLine("Плотности равны.");
            }
        }

        static void task9()
        {
            double voltage1 = 12.0; // Напряжение на первом участке
            double resistance1 = 4.0; // Сопротивление на первом участке

            double voltage2 = 9.0; // Напряжение на втором участке
            double resistance2 = 3.0; // Сопротивление на втором участке

            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;

            if (current1 < current2)
            {
                Console.WriteLine("Меньший ток проходит через первый участок.");
            }
            else if (current1 > current2)
            {
                Console.WriteLine("Меньший ток проходит через второй участок.");
            }
            else
            {
                Console.WriteLine("Токи равны.");
            }
        }

        static void task10()
        {
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            task10();
            Console.ReadKey();
        }
    }
}
