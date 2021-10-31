using System;

namespace _003_Control_Constructs__Branching_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine($"int.MaxValue = {int.MaxValue}");
            Console.WriteLine($"int.MinValue = {int.MinValue}");

            int randomIntResult = random.Next();
            Console.WriteLine($"Пример 1 randomIntResult: {randomIntResult}");
            Console.WriteLine($"Пример 2 randomIntResult random.Next(100) (0-100): {random.Next(100)}");
            Console.WriteLine($"Пример 2 randomIntResult random.Next(10, 100) (10-100): {random.Next(10,100)}");
            Console.WriteLine($"Пример 2 randomDoubleResult random.NextDouble(): {random.NextDouble()}");
        }
    }
}
