using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Вопрос по вычислениям переменных типа float
            //При работе с числовыми переменными с плавающей запятой(float) возникла сложность c точностью вычислений:
            //887,6 - 89,02 = 798,58
            //849,86 - 92,37 = 757,49
            //900,82 - 355,12 = 545,7
            //692,89 - 831,74 = -138,85
            //567,02 - 521,81 = 45,21002
            //568,93 - 758,73 = -189,8
            //7,35 - 573,08 = -565,73
            //307,38 - 373,37 = -65,98999
            //216,79 - 529,63 = -312,84
            //908,74 - 534,91 = 373,83
            //639,23 - 610,47 = 28,76001
            //139,17 - 346,7 = -207,53

            //как сделать так, чтобы быть уверенным в точности вычислений? это будет в курсе?
            #endregion
            floatCount();

            #region Задание 1. Финансовый учет. Task1_FinancialAccounting
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10
            #endregion
            //Task1_FinancialAccounting();

            #region Задание 2. Треугольник Паскаля
            // * Задание 2
            // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля
            #endregion

            #region Задание 3.1. Умножение матрицы на число.
            // 
            // * Задание 3.1
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |
            //
            #endregion

            #region Задание 3.2. Сложение и вычитание матриц
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
            //
            #endregion

            #region Задание 3.3. Перемножение матриц
            // *** Задание 3.3
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //
            #endregion
        }

        #region Вопрос по вычислениям переменных типа float (код)
        static void floatCount()
        {
            // сложности с точностью высчилений чисел с плавающей запятой
            Random random2 = new Random();
            float cel, drob, op1, op2, result;
            for (int i = 0; i < 12; i++)
            {
                op2 = random2.Next(1000) + (float)Math.Round(random2.NextDouble(), 2);
                cel = random2.Next(1000);
                drob = (float)Math.Round(random2.NextDouble(), 2);
                op1 = cel + drob;
                result = op1 - op2;
                Console.WriteLine($"{op1} - {op2} = {result}");
            }
            Console.ReadKey();
        }
        #endregion

        #region Задание 1. Финансовый учет. Task1_FinancialAccounting (реализация)
        static void Task1_FinancialAccounting()
        {
            #region Задание 1. Финансовый учет
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10
            #endregion


            Console.OutputEncoding = Encoding.GetEncoding("utf-8");

            List<MonthAcc> year = new List<MonthAcc>();
            decimal[] incomes = new decimal[] { 100000, 120000, 80000, 70000, 100000, 200000, 130000, 150000, 190000, 110000, 150000, 100000};
            decimal[] expenses = new decimal[] { 80000, 90000, 70000, 70000, 80000, 120000, 140000, 65000, 90000, 70000, 120000, 80000 };
            decimal[] profit = new decimal[12];
            decimal[] forWork = new decimal[12];        // промежуточный массив, чтобы выполнить сортировку по доходности, но не потерять индексы
            int[] indexesMins = new int[3];         // индексы (месяцы) минимумов
            int[] indexesPositives = new int[12];   // индексы доходных месяце
            decimal[,] minsAndNegatives = new decimal[2,12]; // минимумы и отрицательные доходы. в строке 0 - минимумы, в 1 - отрицательные

            Console.WriteLine("Задание 1. Финансовый учет.");
            Console.WriteLine("Выберете вариант отчета:");
            Console.WriteLine("1 - Данные из задания (по умолчанию)");
            Console.WriteLine("2 - Сгенерировать данные");
            char choos = Console.ReadKey().KeyChar;
            switch (choos)
            {
                case '1':
                    break;
                case '2':
                    Random random = new Random();
                    for (int i = 0; i < 12; i++)
                    {
                        incomes[i] = random.Next(1000000) + (decimal)Math.Round(random.NextDouble(), 2);
                        expenses[i] = random.Next(1000000) + (decimal)Math.Round(random.NextDouble(), 2);
                    }
                    break;
                default:
                    break;
            }
            
            Console.WriteLine($"{"Месяц",6} {"Доход, тыс. руб.",21} {"Расход, тыс. руб.",21} {"Прибыль, тыс. руб.", 21}");
            for (int i = 0; i < 12; i++)
            {
                //year.Add(new MonthAcc() { MonthAccNumber = i, income = incomes[i], expense = expenses[i], profit = incomes[i] - expenses[i] });
                profit[i] = incomes[i] - expenses[i];
                //Console.WriteLine($"{ i + 1, 6} {incomes[i], 21}{expenses[i],21}{profit[i],21}");
                //Console.WriteLine($"{ i + 1,6} {incomes[i],21:C2}{expenses[i],21:C2}{profit[i],21:C2}");
                Console.WriteLine($"{ i + 1,6} {incomes[i],21:N2}{expenses[i],21:N2}{profit[i],21:N2}");
                //Console.WriteLine("{0} {1}", (i+1).ToString("G"), incomes[i].ToString("C2"));

                //Console.WriteLine($"{year.Where(y => y.monthNumber == i).FirstOrDefault().income}");
                forWork[i] = profit[i];
            }
            Console.WriteLine();
            Array.Sort(forWork);

            //foreach (var item in forWork)
            //{
            //    Console.WriteLine(item);
            //}

            // заполняем массив минимальных прибылей и заодно ищем отрицательные прибыли и заполняем массив отрицательными прибылями
            for (int i = 0; i < 12; i++)
            {
                if (i < 3)
                {
                    minsAndNegatives[0, i] = forWork[i];
                }
                if (profit[i] > 0)
                {
                    minsAndNegatives[1, i] = forWork[i];
                    indexesPositives[i] = i;
                }
                else
                {
                    minsAndNegatives[1, i] = 0;
                }
            }

            //ищем индексы минимальных прибылей в массиве прибылей
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (profit[j] == minsAndNegatives[0, i])
                    {
                        if (!indexesMins.Contains(j)) indexesMins[i] = j;
                    }
                }
            }


            string t4k = "";
            Console.Write($"Худшая прибыль в месяцах: ");
            Array.Sort(indexesMins);
            for (int i = 0; i < 3; i++)
            {
                t4k = (i == 2) ? "" : ",";
                Console.Write($"{indexesMins[i] + 1}{t4k}");
            }
            Console.WriteLine();

            // Вариант 1, с применением LINQ
            int positives = indexesPositives.Where(pos => pos > 0).Count();
            Console.Write($"Месяцев с положительной прибылью: {positives} (");
            int value = 0;
            foreach (var item in indexesPositives.Where(pos => pos > 0))
            {
                t4k = (positives == 1) ? "" : ",";
                value = item + 1;
                Console.Write($"{value}{t4k}");
                positives--;
            }
            Console.WriteLine(")");

            //


            Console.ReadKey();
        }
        #endregion

        /// <summary>
        /// хотел сделать класс с хранением данных одного месяца, но не получилось реализовать сортировщики по разным полям класс в списке (List<T>)
        /// </summary>
        public class MonthAcc : IComparable<MonthAcc>
        {
            public int MonthAccNumber;
            public float income;
            public float expense;
            public float profit;
            //public int CompareTo(MonthAcc compareMonthAcc)
            //{
            //    // A null value means that this object is greater.
            //    if (compareMonthAcc == null)
            //        return 1;

            //    else
            //        return this.MonthAccNumber.CompareTo(compareMonthAcc.MonthAccNumber);
            //}
            public int CompareTo(MonthAcc compareProfit)
            {
                // A null value means that this object is greater.
                if (compareProfit == null)
                    return 1;

                else
                    return this.profit.CompareTo(compareProfit.profit);
            }
            public override int GetHashCode()
            {
                return MonthAccNumber;
            }
        }
    }
}
