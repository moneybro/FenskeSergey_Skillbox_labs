using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab001_001_Hello_world
{
    static class Lab002_001_Format_view
    {
        static string pattern = "param1 = {0}, param2 = {1}, param3 = {2}";
        static string p1 = "value1";
        static string p2 = "value2";
        static string p3 = "value3";

        public static void DoWorklab2()
        {
            Console.WriteLine("Lab2. Format view");
            Console.WriteLine(pattern,
                p1,
                p2,
                p3);
        }

        #region Вывод данных Escape-последовательности

        // \n - новая строка
        // \r - возврат корретки
        // \t - горизонтальная табуляция
        // \' - одиночная ковычка
        // \" - двойная ковычка
        // \\ - обратный слэш
        // \? - литерал вопросительного знака

        #endregion

        #region Калькулятор

        static int a = 1234567890;
        static int b = 200;
        static int c = 300;

        /// <summary>
        /// {a, 7} - второй параметр указывает на то, сколько мест под символы выделить под значение переменной
        /// если не хватает, то автоматом добавится, если места больше, чем символов, то даст это место с выравниманием по правому краю
        /// </summary>
        public static void DoWorklab2_Interpolation()
        {

            Console.WriteLine($"{a, 15} + {b, 7} = {c, 7}\n");

            var date = new DateTime(2025, 09, 28, 01, 30, 59);

            Console.WriteLine("Вывод даты:");
            Console.WriteLine($"Шаблон HH:mm: {date:HH:mm}");
            Console.WriteLine($"Шаблон yyyy-MMMM-dd: {date:yyyy-MMMM-dd}");
            Console.WriteLine($"Шаблон yy.MM.dd: {date:yy.MM.dd}");
            Console.WriteLine($"Шаблон dd.MM.yyy: {date:dd.MM.yyy}");
        }
        #endregion

    }
}

