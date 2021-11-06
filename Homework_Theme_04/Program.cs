﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

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
            //floatCount();

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
            Task1_FinancialAccounting();

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
            //CountPascalTreangle(9);

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
            //matrixMultiplicationByNumber();

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
                WriteLine($"{op1} - {op2} = {result}");
            }
            ReadKey();
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


            OutputEncoding = Encoding.GetEncoding("utf-8");

            List<MonthAcc> year = new List<MonthAcc>();
            //decimal[] incomes = new decimal[] { 100000, 120000, 80000, 70000, 100000, 200000, 130000, 150000, 190000, 110000, 150000, 100000 };
            //decimal[] expenses = new decimal[] { 100000, 90000, 1800000, 70000, 80000, 120000, 140000, 65000, 90000, 70000, 120000, 80000 };
            //decimal[] expenses = new decimal[] { 80000, 90000, 70000, 70000, 80000, 120000, 140000, 65000, 90000, 70000, 120000, 80000 };

            //decimal[] incomes = new decimal[] { 00000, 20000, -20000, -30000, 00000, 100000, 30000, 50000, 90000, 10000, 50000, 00000 };
            //decimal[] expenses = new decimal[] { 50000, 70000, 30000, 20000, 50000, 150000, 80000, 100000, 140000, 60000, 100000, 50000 };

            decimal[] incomes = new decimal[] { 2, 3, 2, 3, 2, 3, 1, 3, 3, 2, 1, 2 };
            decimal[] expenses = new decimal[] { 3, 2, 3, 3, 1, 2, 3, 3, 1, 3, 2, 1 };

            decimal[] profit = new decimal[12];
            decimal[] forWork = new decimal[12];        // промежуточный массив, чтобы выполнить сортировку по доходности, но не потерять индексы
            decimal[] minProfitValues = new decimal[3]; // для хранения 3 минимальных прибылей
            int[] indexesMins = new int[12];         // индексы (месяцы) минимумов
            int[] indexesPositives = new int[12];   // индексы доходных месяце

            WriteLine("Задание 1. Финансовый учет.");
            WriteLine("Выберете вариант отчета:");
            WriteLine("1 - Данные из задания (по умолчанию)");
            WriteLine("2 - Сгенерировать данные");
            char choos = ReadKey().KeyChar;
            switch (choos)
            {
                case '1':
                    break;
                case '2':
                    Random random = new Random();
                    for (int i = 0; i < 12; i++)
                    {
                        incomes[i] = random.Next(1000000) + (decimal)Math.Round(random.NextDouble(), 2); // генерим значение с копейками
                        expenses[i] = random.Next(1000000) + (decimal)Math.Round(random.NextDouble(), 2);
                    }
                    break;
                default:
                    break;
            }
            CursorLeft = 0;
            WriteLine($"{"Месяц",6} {"Доход, тыс. руб.",21} {"Расход, тыс. руб.",21} {"Прибыль, тыс. руб.",21}");
            
            
            for (int i = 0; i < 12; i++)
            {
                //year.Add(new MonthAcc() { MonthAccNumber = i, income = incomes[i], expense = expenses[i], profit = incomes[i] - expenses[i] });
                profit[i] = incomes[i] - expenses[i];
                //WriteLine($"{ i + 1, 6} {incomes[i], 21}{expenses[i],21}{profit[i],21}");
                //WriteLine($"{ i + 1,6} {incomes[i],21:C2}{expenses[i],21:C2}{profit[i],21:C2}");
                WriteLine($"{ i + 1,6} {incomes[i],21:N2}{expenses[i],21:N2}{profit[i],21:N2}");
                //WriteLine("{0} {1}", (i+1).ToString("G"), incomes[i].ToString("C2"));

                //WriteLine($"{year.Where(y => y.monthNumber == i).FirstOrDefault().income}");
                forWork[i] = profit[i];

            }
            Array.Sort(forWork);
            List<decimal> unikalnye = new List<decimal>(); 
            for (int i = 0; i < 12; i++)
            {
                if (!unikalnye.Contains(forWork[i])) unikalnye.Add(forWork[i]); // сохраняем уникальные значения из сортированного массива с прибылями
            }

            WriteLine();

            // заполняем массив индексов положительных прибылей, если прибыль положительная, то записываем индекс, если нет - то записываем -1, чтобы потом было легко отделить
            for (int i = 0; i < 12; i++)
            {
                if (profit[i] > 0)
                {
                    indexesPositives[i] = i;
                }
                else
                {
                    indexesPositives[i] = -1;
                }
            }

            //ищем индексы(месяцы) минимальных прибылей в массиве прибылей, которые равны любому из трех минимальных значений прибыли
            for (int i = 0; i < 12; i++)
            {
                if (unikalnye.Take(3).Contains(profit[i])) indexesMins[i] = i; // если значение прибыли содержится в выборке первых трех минимальных и уникальных значений, то сохраняем индекс
                else
                {
                    indexesMins[i] = -1; // если нет, то заполняем -1, чтобы потом было легко отобрать индексы
                }
            }


            string t4k = "";
            Write($"Худшая прибыль в месяцах: ");
            Array.Sort(indexesMins);
            int minsCount = indexesMins.Where(v => v > 0).Count(); // определяем количество индексов(месяцев), в которых была минимальная прибыль

            int iterator2 = 0;  // итератор по количеству индексов
            for (int i = 0; i < 12; i++)
            {
                t4k = (iterator2 == minsCount || i == 11) ? "" : ",";   // ждем либо последнее значение цикла либо, итератор ставит равен количеству минимальных прибылей, как оно наступает, вместо запятой в конце строки ставим "". если условие не выполняется - ставим ","
                if (indexesMins[i] >= 0) 
                {
                    Write($"{++indexesMins[i]}{t4k}");  // выводим индексы, предварительно увеличив их на 1 (из-за массива, где счет начинается с 0), минимальных прибылей
                    iterator2++;                        // увеличиваем итератор
                }
            }
            WriteLine();

            int positives = indexesPositives.Where(pos => pos >= 0).Count(); // с помощью LINQ выбирается коллекция положительних прибылей
            Write($"Месяцев с положительной прибылью: {positives} (");
            int value = 0;
            foreach (var item in indexesPositives.Where(pos => pos >= 0))
            {
                t4k = (positives == 1) ? "" : ",";  // ждем последнее значение цикла, как оно наступает "," не ставим. пока ждем - ставим ","
                value = item + 1;
                Write($"{value}{t4k}");
                positives--;
            }
            WriteLine(")");
            ReadKey();
        }


        /// <summary>
        /// хотел сделать класс с хранением данных одного месяца, но не получилось реализовать сортировщики по разным полям класса в списке (List<T>). отдельно сортировщики работают, но сделать, чтобы сортировка была по нужному полю при передаче параметра не удалось. сложные делигаты
        /// </summary>
        public class MonthAcc : IComparable<MonthAcc>
        {
            public int MonthAccNumber;
            public float income;
            public float expense;
            public float profit;


            // реализация сортировщика по полю MonthAccNumber (номер месяца)
            //public int CompareTo(MonthAcc compareMonthAcc)
            //{
            //    // A null value means that this object is greater.
            //    if (compareMonthAcc == null)
            //        return 1;

            //    else
            //        return this.MonthAccNumber.CompareTo(compareMonthAcc.MonthAccNumber);
            //}

            // реализация сортировщика по полю profit (прибыль)
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
        #endregion

        #region Задание 2. Треугольник Паскаля (реализация)

        /// <summary>
        /// Метод строит треугольник Паскаля с помощью двух вложенных циклов с постусловием. Выбран именно этот тип цикла потому, что требуется хотя бы одна итерация.
        /// Задание решается в 2 этапа:
        /// 1. Заполнение зубчатого массива элементами треугольника, которые вычисляются одновременно с заполнением массива. Реализация задумывалась так, чтобы не хранить элементы, а сразу выводить на экран, а потом формитировать. Но отформатировать вывод в консоли не удалось, поэтому пришлось сделать хранение элементов.
        /// 2. Вывод на экран с форматированием. Реализовано динамическое форматирование: при заполнении массива запоминается максимальная длина в символах самого длинного элемента. Далее эта длина используется для вычисления общей длины строки и промежутков между элементами.
        /// </summary>
        /// <param name="count">Параметр задает первичное количество строк N треугольника</param>
        static void CountPascalTreangle(int count)
        {
            if (count == 0)
            {
                count = 1;
            }
            WriteLine($"n = {count}");
            int n = 0, zadanie = count, elMaxLength = 0; // zadanie - переменная задает количество строк текущего треугольника, n - счетчик количества итераций внешнего цика, elMaxLength - максимальная длина в символах максимального элемента треугольника
            double[][] storage = new double[zadanie][]; // зубчатый массив хранения элементов треугольника. первое значение указывает количество строк, второе - количество элементов в строке
            int[] strLen = new int[zadanie];    // массив для хранения сумм длин всех элементов массива строки треугольника без пробелов

            do
            {
                int i = 0;  // итератор внутреннего цикла, для перебора элементов массива, который формирует строку треугольника
                storage[n] = new double[n + 1]; // создаем массив для хранения элементов строки
                do
                {
                    if (i == 0 || i == (n))     // если первый или последний элемент
                    {
                        storage[n][i] = 1;      // то присваиваем 1
                        strLen[n] += storage[n][i].ToString().Length; // увеличиваем длину строки на длину элемента в символов
                    }
                    else
                    {
                        storage[n][i] = storage[n - 1][i - 1] + storage[n - 1][i]; // вычисляется текущий элемент треугольника как сумма элементов "над ним" (предыдущая строка, индексы i-1 + i) 
                        strLen[n] += storage[n][i].ToString().Length; // увеличиваем длину строки на длину элемента в символов

                        // проверяем максимальную длину элемента в символах и сохраняем ее если она максимальная
                        if (elMaxLength < storage[n][i].ToString().Length + 1)
                        {
                            elMaxLength = storage[n][i].ToString().Length + 1;
                        }
                    }
                    i++;    // увеличиваем счетчик внутреннего цикла, индекс элемента в строке
                }
                while (i <= n); // проверяем выход из цикла
                n++;   // увеличиваем счетчик внешнего цикла, индекс строки треугольника
            }
            while (n < zadanie); // проверяем выход из цикла

            // блок вывода треугольника на экран
            int offset;
            int maxStringLenghtWithSpaces = (zadanie - 1) * elMaxLength + 1; // максимальная длина строки, определяется как количество элементов в последней строке треугольника минус 1 умножить на максимальную длину максимального элемента треугольника плюс один, потому что после последнего элемента не выводим пробелы
            for (int i = 0; i < n; i++) // цикл перебова строк массива
            {
                try
                {
                    int currentStringWithSpaces = (elMaxLength * (storage[i].Length - 1) + 1); // длина текущей строки, опеределяется как количество элементов в текущей строке минус 1 умножить на максимальную длину максимального элемента треугольника плюс один, потому что после последнего элемента не выводим пробелы
                    offset = maxStringLenghtWithSpaces / 2 - (currentStringWithSpaces / 2); // определяем сдвиг как половина длины максимально длинной строки - половина длины текущей строки
                    CursorLeft = offset; // сдвигаем курсов
                    for (int j = 0; j < storage[i].Length; j++) // цикл перебора элементов в строке
                    {
                        string tail = (j == (storage[i].Length - 1)) ? "" : new string('.', (elMaxLength - storage[i][j].ToString().Length)); // вычисляем "хвост" элемента, как разность длины элемента в символах и длины максимального элемента треугольника в символах. если элемент последний в строке, то хвоста нет
                        Write($"{storage[i][j]}{tail}"); // вывод элемента и "хвоста" (отступа до следующего элемента)
                    }
                    WriteLine();
                }
                catch (Exception)
                {
                    // элемент введен, чтобы ловить ошибку слишком большого сдвига, который вызывал ошибку переполнения буфера вывода консоли
                    //WriteLine("максимальная длина строки:{0}", maxStringLenghtWithSpaces);
                    //WriteLine("отступ:{0}", offset);
                }

            }
            WriteLine();
            ReadKey();
            CountPascalTreangle(++zadanie); // перезапуск метода с количеством шагов + 1 к предыдущему значению
        }


        #endregion

        #region Задание 3.1. Умножение матрицы на число.

        static void matrixMultiplicationByNumber()
        {
            Clear();
            int arrStringItemsCount, arrColumnsCount, multiplier, multiplierCharsCount, randomLimit;
            int[,] sourceArr, targetArr;
            string el;
            WriteLine("Введите количество строк матрицы (можно много): ");
            arrStringItemsCount = getValidIntFromLine();
            WriteLine("Введите количество столбцов матрицы (желательно не очень много, чтобы за экран не убегало): ");
            arrColumnsCount = getValidIntFromLine();
            WriteLine("Введите множитель матрицы: ");
            multiplier = getValidIntFromLine();
            WriteLine("Введите лимит рандомайзера (от - лимит до лимит): ");
            randomLimit = getValidIntFromLine();
            WriteLine();
            //arrStringItemsCount = 5;
            //arrColumnsCount = 5;
            //multiplier = 99;

            WriteLine($"Размер массива: строк={arrStringItemsCount} столбцов={arrColumnsCount}. Множитель={multiplier}. Лимит(-{randomLimit}, {randomLimit})");
            WriteLine();
            multiplierCharsCount = multiplier.ToString().Length;
            sourceArr = new int[arrStringItemsCount, arrColumnsCount];
            targetArr = new int[arrStringItemsCount, arrColumnsCount];
            int maxResElementWidth, maxResElement = 0, sourceMatrixColumnWidth;
            bool maxElIsNegative = false;

            Random random = new Random();
            
            // заполнение матриц, определение максимального элемента в рез-щей матрице, чтобы потом взять его длину в символах
            for (int i = 0; i < arrStringItemsCount; i++)
            {
                for (int j = 0; j < arrColumnsCount; j++)
                {
                    //sourceArr[i, j] = -100;
                    sourceArr[i, j] = random.Next(-randomLimit, randomLimit);

                    targetArr[i, j] = sourceArr[i, j] * multiplier;
                    if (maxResElement < Math.Abs(targetArr[i,j]))   // максимальное число по модулю
                    {
                        maxResElement = Math.Abs(targetArr[i, j]);  // запоминаем максимальное число
                        maxElIsNegative = true;                     // максимальное число по модулю было отрицательным
                    }
                }
            }

            maxResElementWidth = maxElIsNegative ? maxResElement.ToString().Length + 2 : maxResElement.ToString().Length + 1;   // длина в символах максимального элемента рез-щего массива и если элемент был отрицательный, то добавляем к длине 1 для знака. также один знак для пробела
            sourceMatrixColumnWidth = randomLimit.ToString().Length + 2; // длина максимального случайного элемента в символах
            string separator = " * " + multiplier.ToString() + " = ";   // разделитель выводит множитель матрицы
            
            // вывод матриц
            for (int i = 0; i < arrStringItemsCount; i++)
            {
                int matrix1Width = 2 + arrColumnsCount * sourceMatrixColumnWidth + 1; // 2- для "| ", потом количество столбцов на максимальную длину элемента + знак + пробел (4 - потому что числа выбираются из диапазона от -10 до 10, то есть максимальная длина - 2, + знак + пробел)
                int matrix2Offset = matrix1Width + separator.Length;
                
                Write("| ");

                if (i != arrStringItemsCount / 2)
                {
                    separator = new string(' ', separator.Length);
                }
                else
                {
                    separator = " * " + multiplier.ToString() + " = ";
                }

                for (int j = 0; j < arrColumnsCount; j++)
                {
                    string matrix1Separator = (j == (arrColumnsCount - 1)) ? "|" : "";
                    string matrix2Separator = (j == 0) ? "|" : "";

                    el = (sourceArr[i, j] >= 0 ? " " + sourceArr[i, j].ToString() : sourceArr[i, j].ToString());

                    Write(el); // вывод исходного массива
                    //Thread.Sleep(100);

                    CursorLeft = matrix1Width - 1; 
                    Write(matrix1Separator + separator);    // вывод верт скобки + множителя матрицы

                    try
                    {
                        int elMatrix2Offset;
                        if (j == 0)
                        {
                            elMatrix2Offset = matrix2Offset + j * maxResElementWidth; 
                        }
                        else
                        {
                            elMatrix2Offset = matrix2Offset + j * maxResElementWidth + 1; // если не первый элемент рез-щей матрицы, то добавляем к сдвигу расстояние для вертикальной скобки и первого пробела
                        }
                        CursorLeft = elMatrix2Offset;
                    }
                    catch
                    {
                        //SetCursorPosition(0, arrStringItemsCount + 1);
                    }
                    el = (targetArr[i, j] >= 0 ? " " + targetArr[i, j].ToString() : targetArr[i, j].ToString()); // если элемент положительный, то вместо знака добавляем пробел

                    Write($"{matrix2Separator} {el}");  // вывод вертикальной скобки и элемента рез-щей матрицы
                    CursorLeft = 2 + (j + 1) * sourceMatrixColumnWidth;       // отступ для очередного элемента строки массива
                }
                try
                {
                    CursorLeft = matrix2Offset + arrColumnsCount * (maxResElementWidth) + 1;    // отступ для отрисовки закрывающей вертикальной скобки рез-щей матрицы
                }
                catch
                {
                    // защита от ошибки если вдруг матрицы будут слишком большие и сдвиг будет больше ширины окна консоли
                }
                WriteLine($" |");
            }

            ReadKey();
            matrixMultiplicationByNumber();
        }

        /// <summary>
        /// Метод предназначен для обеспечения валидности ввода целочисленных значений
        /// </summary>
        /// <returns></returns>
        static int getValidIntFromLine()
        {
            int result;
            bool needClean = false;
            while (true)
            {
                string enter = ReadLine();
                bool success = int.TryParse(enter, out result);
                if (success)
                {
                    if (needClean)
                    {
                        SetCursorPosition(0, CursorTop);
                        Write(new string(' ', WindowWidth));
                        SetCursorPosition(0, --CursorTop);
                    }
                    return result;
                }
                else
                {
                    Write("Неверный ввод. Повторите");
                    SetCursorPosition(0,--CursorTop);
                    Write(new string(' ', WindowWidth));
                    SetCursorPosition(0, --CursorTop);
                    needClean = true;
                }
            }
        }

        #endregion
    }
}
