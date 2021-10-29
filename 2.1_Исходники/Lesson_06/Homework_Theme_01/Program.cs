using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - эл. почта (по заданию с сайта, было рост);
            //    - баллы по трем предметам: программирование, математика, физика
            //    (по заданию с сайта, было: история, математика, русский язык);

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печати информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

            

            #region cоздаем студентов
            Student st1 = new Student {
                FullName = "Иванов Иван Иванович",
                Age = 17,
                Email = "ivanov@ivan.io",
                PointsProgramming = 5,
                PointsMath = 4,
                PointsPhisic = 5 };

            Student st2 = new Student
            {
                FullName = "Петров Петр Петрович",
                Age = 18,
                Email = "petrov@petr.po",
                PointsProgramming = 8,
                PointsMath = 6,
                PointsPhisic = 7
            };

            Student st3 = new Student
            {
                FullName = "Васин Василий Васильевич",
                Age = 20,
                Email = "vasin@vasya.va",
                PointsProgramming = 5,
                PointsMath = 9,
                PointsPhisic = 9
            };

            #endregion окончание создания студентов

            Console.WindowWidth = 150; // устанавливаем размер окна консоли

            #region Обычный вывод. Вызов
            Console.WriteLine("Обычный вывод:");
            simplePrint(st1.StudentToString()); // выводим студента 1 методом простого/обычного вывода
            simplePrint(st2.StudentToString()); // выводим студента 2 методом простого/обычного вывода
            simplePrint(st3.StudentToString()); // выводим студента 3 методом простого/обычного вывода
            Console.ReadKey();
            Console.WriteLine(); // пропускаем строку после вывода
            #endregion

            #region Форматированный вывод. Вызов
            Console.WriteLine("Форматированный вывод:");
            Console.WriteLine(new string ('-', 107)); // выводим строку из 107 тире, для шапки таблицы
            printTableHead(); // формирование и вывод шапки таблицы
            Console.WriteLine(new string('-', 107)); // выводим строку из 107 тире, для шапки таблицы
            printTableLine(st1.StudentToString());  // выводим студента 1 методом форматированного вывода, передаем текстовое представление объекта студента в метод, форматирование и вывод текста происходит в методе
            printTableLine(st2.StudentToString()); // выводим студента 2 методом форматированного вывода
            printTableLine(st3.StudentToString()); // выводим студента 3 методом форматированного вывода
            Console.ReadKey();
            Console.WriteLine(); // пропускаем строку после вывода
            #endregion

            # region Вывод с помощью интерполяции строк. Вызов
            Console.WriteLine("Вывод с помощью интерполяции строк");
            stringInterpolationPrint(st1.StudentToString()); // выводим студента 1 методом, который использует интерполяцию строк
            stringInterpolationPrint(st2.StudentToString()); // выводим студента 2 методом, который использует интерполяцию строк
            stringInterpolationPrint(st3.StudentToString()); // выводим студента 3 методом, который использует интерполяцию строк
            #endregion

            Console.ReadKey(); // ожидание нажатия кнопки, чтобы задержать вывод на экране
        }

        #region Обычный вывод. Реализация
        /// <summary>
        /// метод предназначен для простого/обычного вывода элементов строкового массива, который передается в метод
        /// метод предусматривает возможность вывода массива любой длины
        /// </summary>
        /// <param name="st">строковый массив, элементы которого будут выводиться</param>
        static void simplePrint(string[] st)
        {   
            string str = "";                    // временная переменная для формирования строки, состоящей из строк - элементов массива
            for (int i = 0; i < st.Length; i++) // перебираем массив строк
            {
                str += "| " + st[i] + " ";      // производим конкатинацию строк - элементов массива    
            }
            Console.WriteLine(str + "|");       // выводим результирующую строку
        }
        #endregion

        #region Форматированный вывод. Реализация
        /// <summary>
        /// метод формирует "шапку" таблицы форматированного вывода и вызывает метод отображения printTableLine. в качестве элементов массива передаем заголовки столбцов
        /// </summary>
        static void printTableHead()
        {
            string[] tableHead = new string[]       // формируем массив строк для "шапки" таблицы
            { 
            "Ф.И.О.",
            "Возраст",
            "Эл.почта",
            "Прогр.",
            "Матем.",
            "Физика",
            "Общ.балл"
            };
            
            printTableLine(tableHead);              // вызываем метод отображения строки, состоящей из элементов массива
        }

        /// <summary>
        /// метод выводит элементы массива, который принимается через переменную st типа массива строк.
        /// форматирование происходит путем сдвига курсора с помощью свойства CursorLeft. после вывода очередного элемента массива произодится сдвиг курсора на количество символов, указанного в переменных col1W - col7W, являющиеся по сути шириной столбцов.
        /// </summary>
        /// <param name="st">строковый массив, элементы которого будут выводиться</param>
        static void printTableLine(string[] st)
        {
            short col1W = 25; // ширина столбца 1 (column1Width)
            short col2W = 10; // ширина столбца 2 (column1Width)
            short col3W = 25; // ширина столбца 3 (column1Width)
            short col4W = 10; // ширина столбца 4 (column1Width)
            short col5W = 15; // ширина столбца 5 (column1Width)
            short col6W = 10; // ширина столбца 6 (column1Width)
            short col7W = 10; // ширина столбца 7 (column1Width)

            Console.Write(st[0]);                                                       // выводим элемент массива 1 без переноса на новую строку
            Console.CursorLeft = col1W;                                                 // сдвигаем курсов на ширину колонок
            Console.Write(" | " + st[1]);                                               // выводим элемент массива 2 без переноса на новую строку
            Console.CursorLeft = col1W + col2W;                                         // сдвигаем курсов на ширину колонок
            Console.Write(" | " + st[2]);                                               // выводим элемент массива 3 без переноса на новую строку
            Console.CursorLeft = col1W + col2W + col3W;                                 // сдвигаем курсов на ширину колонок
            Console.Write(" | " + st[3]);                                               // выводим элемент массива 4 без переноса на новую строку
            Console.CursorLeft = col1W + col2W + col3W + col4W;                         // сдвигаем курсов на ширину колонок
            Console.Write(" | " + st[4]);                                               // выводим элемент массива 5 без переноса на новую строку
            Console.CursorLeft = col1W + col2W + col3W + col4W + col5W;                 // сдвигаем курсов на ширину колонок
            Console.Write(" | " + st[5]);                                               // выводим элемент массива 6 без переноса на новую строку
            Console.CursorLeft = col1W + col2W + col3W + col4W + col5W + col6W;         // сдвигаем курсов на ширину колонок
            Console.Write(" | " + st[6]);                                               // выводим элемент массива 7 без переноса на новую строку
            Console.CursorLeft = col1W + col2W + col3W + col4W + col5W + col6W + col7W; // сдвигаем курсов на ширину колонок
            Console.Write(" | \n");                                                     // выводим символ |, переносим курсор на новую строку
        }
        #endregion

        # region Вывод с помощью интерполяции строк. Реализация
        /// <summary>
        /// метод выводит элементы строкового массива с помощью интерполяции строк
        /// </summary>
        /// <param name="st">строковый массив, элементы которого будут выводиться</param>
        static void stringInterpolationPrint(string[] st)
        {
            Console.WriteLine($"{st[0]} | {st[1]} | {st[2]} | {st[3]} | {st[4]} | {st[5]} | {st[6]} |"); // вывод с помощью интерполяции
        }
        #endregion

        # region класс Student
        /// <summary>
        /// класс описывающий студента
        /// </summary>
        public class Student
        {
            public string FullName { get; set; }            // св-во Полное имя (ФИО)
            public short Age { get; set; }                  // св-во Возраст (количество лет), наверное было бы правильнее хранить дату рождения, а возраст подсчитывать относительно текущей даты
            public string Email { get; set; }               // св-во Эл почта
            public float PointsProgramming { get; set; }    // св-во Очки по программированию
            public float PointsMath { get; set; }           // св-во Очки по математике
            public float PointsPhisic { get; set; }         // св-во Очки по физике

            // метод возвращает среднюю оценку по предметам, путем подсчета среднего арифметического по 3 предметам. тип возвращаемого значения float
            public float getMiddlePoint()
            {
                return (PointsMath + PointsPhisic + PointsProgramming) / 3;
            }

            // метод формирует и заполняет значениями строковый массив, который и возвращает. Не строковые свойства объекта Student предварительно приводятся к строковым значениям
            public string[] StudentToString()
            {
                string[] st = new string[]          // формирование нового строкового массива
                // заполнение массива
                {
                    FullName,
                    Age.ToString(),                 // метод ToString() производит явное преобразование значение к строковому значению
                    Email,
                    PointsProgramming.ToString(),
                    PointsPhisic.ToString(),
                    PointsMath.ToString(),
                    getMiddlePoint().ToString()
                };
                return st;                          // возвращаем заполненный массив
            }
        }
        #endregion
    }
}
