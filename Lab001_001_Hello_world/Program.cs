using System;
using static System.Console;

namespace Lab001_001_Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите 1 для HW через WriteLine, 2 - вывод HW через Write");
            string choos = ReadLine();
            switch (choos)
            {
                case "1":
                    PrintHwWithWriteline();
                    break;
                case "2":
                    PrintHwWithWrite();
                    break;
                default:
                    PrintHwWithWriteline();
                    break;
            }
            ReadKey();
        }
        /// <summary>
        /// метод для вывода через WriteLine
        /// </summary>
        static void PrintHwWithWriteline()
        {
            WriteLine("Hello World! (with WriteLine)");
        }

        /// <summary>
        /// метод для вывода через Write
        /// </summary>
        private static void PrintHwWithWrite()
        {
            Write("Hello ");
            Write("World ");
            Write("!!! ");
            Write("(with Write)");
        }
    }
}
