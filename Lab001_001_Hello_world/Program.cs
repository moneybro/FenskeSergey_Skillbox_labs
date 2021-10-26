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
                    PrintHWInline();
                    break;
                case "2":
                    PrintHWInColumn();
                    break;
                default:
                    PrintHWInline();
                    break;
            }
            ReadKey();
        }

        static void PrintHWInline()
        {
            WriteLine("Hello World! (with WriteLine)");
        }

        private static void PrintHWInColumn()
        {
            Write("Hello ");
            Write("World ");
            Write("!!! ");
            Write("(with Write)");
        }
    }
}
