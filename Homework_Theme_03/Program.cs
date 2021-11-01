using System;
using System.Linq;
using static System.Console;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!

            StartApp();
        }

        public static string[] gamers = new string[2];
        public static int GameNumber { get; set; }
        static void StartApp()
        {
            Random random = new Random();
            GameNumber = random.Next(20, 120);
            WriteLine("Вас приветствует игра Пирамида.");
            WriteLine("Участвуют 2 игрока.");
            
            for (int i = 0; i < gamers.Length; i++)
            {
                gamers[i] = setGamersNicknames(i);
                WriteLine($"Игрок {i + 1} с ником {gamers[i]} успешно добавлен.");
            }

            WriteLine(new string('-', WindowWidth));

            WriteLine("Итого участвуют игроки с никами:");
            foreach (var gamer in gamers)
            {
                WriteLine(gamer);
            }
            WriteLine(new string('-', WindowWidth));


            WriteLine($"Высота пирамиды: {GameNumber}");

            StartMoving();

            ReadKey();
        }

        private static void StartMoving()
        {
            int gameNumberTmp;
            while (true)
            {
                for (int i = 0; i < gamers.Length; i++)
                {
                    bool wrongEnter = true;
                    bool goodMove = false;
                    do
                    {
                        Write($"Ходит игрок {gamers[i]}. Введи число от 1 до 4: ");
                        goodMove = int.TryParse(ReadKey().KeyChar.ToString(), out int step);
                        WriteLine();
                        wrongEnter = !(goodMove && step >= 1 && step <= 4); // если правильный ввод, то выходим из цикала do while
                        if (goodMove && step >= 1 && step <= 4)
                        {
                            CursorLeft = 0;

                            gameNumberTmp = GameNumber - step;
                            if (gameNumberTmp <= 0)
                            {
                                WriteLine($"Победил игрок {gamers[i]}!!! Ура. Качай его, ребята!");
                                return;
                            }
                            else
                            {
                                WriteLine(step);
                                WriteLine($"Высота пирамиды {GameNumber} - {step} = {gameNumberTmp}.");
                                GameNumber = gameNumberTmp;
                            }
                            goodMove = false;
                        }
                        else
                        {
                            Console.WriteLine("Неверный ввод!");
                            continue;
                        }
                    }
                    while (wrongEnter);
                }
            }
        }

        private static string setGamersNicknames(int gamerNumber)
        {
            Write($"Введите ник игрока {gamerNumber + 1}. Ник должен быть длинной не более 8 символов. Длинные ники будут урезаны:");
            string tmpGamerName = ReadLine();
            if (tmpGamerName == "")
            {
                WriteLine($"Имя игрока не может быть пустым, поэтому игроку {gamerNumber + 1} присвоен ник: игрок{gamerNumber + 1}");
                tmpGamerName = "игрок" + (gamerNumber + 1);
                return tmpGamerName;
            }
            while (true)
            {
                if (!gamers.Contains(tmpGamerName))
                {
                    return tmpGamerName;
                }
                else
                {
                    WriteLine($"Такой ник уже есть, генерим новый.");
                    tmpGamerName = generateGamerNick(tmpGamerName, gamerNumber);
                    WriteLine($"Ваш новый ник:{tmpGamerName}");
                    return tmpGamerName;
                }
            }
            
        }
        private static string generateGamerNick(string tmpGamerName, int gamerNumber)
        {
            int i = 1;
            i = gamerNumber++;
            return tmpGamerName + i;
        }
    }
}
