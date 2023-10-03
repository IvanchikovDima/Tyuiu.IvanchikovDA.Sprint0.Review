using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint0.Review.Lib;

namespace Tyuiu.IvanchikovDA.Sprint0.Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Обзор спринта                                                     *");
            Console.WriteLine("* Задание Review                                                          *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Иванчиков Дмитрий Александрович | ПКТБ-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет выражение        *");
            Console.WriteLine("* (x + y + z) * 5                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(DataService.Calc(x, y, z));
            Console.ReadKey();

        }
    }
}
