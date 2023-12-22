using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                   //Компьютерный практикум по информатике №13
            // Задача #1

            // 1-й способ: полный условный оператор

            //Console.Write("Введите число: ");
            //int num = int.Parse(Console.ReadLine()); // 1-sin^2*x^2
            //if (num > 0)
            //{
            //    double result = Math.Pow(Math.Sin(num), 2)*num;
            //    Console.WriteLine($"Результат: {result:F2}");
            //    Console.Write("Число больше нуля, поэтому решено по функции: sin^2*x");
            //}
            //else
            //{
            //    double result = 1-Math.Pow(Math.Sin(num),2)*Math.Pow(num,2);
            //    Console.WriteLine($"Результат: {result:F2}");
            //    Console.Write("Число меньше или равно нулю, поэтому решено по функции: 1-sin^2*x^2");
            //}

            // 2-й способ: тернарная операция

            //Console.Write("Введите число: ");
            //int num = int.Parse(Console.ReadLine());
            //double result = (num > 0) ? Math.Pow(Math.Sin(num), 2) * num : 1 - Math.Pow(Math.Sin(num), 2) * Math.Pow(num, 2);
            //Console.WriteLine($"Результат: {result:F2}");

            // Задача #2
            //Random num = new Random();
            //int x = num.Next(10, 99);
            //string result = (x % 2 == 0) ? "Четное" : "Нечетное";
            //Console.WriteLine($"Число {x} - {result}.");

            // Задача #3
            //Console.Write("Введите первое число: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int number2 = int.Parse(Console.ReadLine());

            //Console.Write("Введите третье число: ");
            //int number3 = int.Parse(Console.ReadLine());

            //if (number1 % 2 == 0 && number2 % 2 == 0 && number3 % 2 == 0)
            //{
            //    number1++;
            //    number2++;
            //    number3++;
            //}
            //else if (number1 % 2 == 0 || number2 % 2 == 0 || number3 % 2 == 0)
            //{
            //    number1--;
            //    number2--;
            //    number3--;
            //}
            //else
            //{
            //    number1 *= 2;
            //    number2 *= 2;
            //    number3 *= 2;
            //}
            //Console.WriteLine($"Результат: {number1}, {number2}, {number3}");

            // Задача #4
            //Random random = new Random();
            //int x = random.Next(-20, 20);
            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine("Январь"); break;
            //    case 2:
            //        Console.WriteLine("Февраль"); break;
            //    case 3:
            //        Console.WriteLine("Март"); break;
            //    case 4:
            //        Console.WriteLine("Апрель"); break;
            //    case 5:
            //        Console.WriteLine("Май"); break;
            //    case 6:
            //        Console.WriteLine("Июнь"); break;
            //    case 7:
            //        Console.WriteLine("Июль"); break;
            //    case 8:
            //        Console.WriteLine("Август"); break;
            //    case 9:
            //        Console.WriteLine("Сентябрь"); break;
            //    case 10:
            //        Console.WriteLine("Октябрь"); break;
            //    case 11:
            //        Console.WriteLine("Ноябрь"); break;
            //    case 12:
            //        Console.WriteLine("Декабрь"); break;
            //    default:
            //        Console.WriteLine("Случайное число не попало в диапазон 1-12"); break;
            //}
                Console.Read();

        }
    }
}
