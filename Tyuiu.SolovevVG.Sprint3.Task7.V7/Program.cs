using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SolovevVG.Sprint3.Task7.V7.Lib;

namespace Tyuiu.SolovevVG.Sprint3.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Соловьев В. Г. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #7                                                               *");
            Console.WriteLine("* Выполнил: Соловьев Валерий Геннадьевич | СМАРТб-23-2                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5, stopValue = 5;
            double[] res = dataService.GetMassFunction(startValue, stopValue);

            Console.WriteLine($"Начало отрезка: {startValue}");
            Console.WriteLine($"Конец отрезка: {stopValue}");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    f(x)   |");
            Console.WriteLine("+----------+-----------+");

            for (int i = 0; i < res.Length; i++, startValue++)
            {
                Console.WriteLine("|{0,5:d}     | {1,6:f2}    |", startValue, res[i]);
            }

            Console.WriteLine("+----------+-----------+");

            Console.ReadKey();
        }
    }
}
