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

            StartGame();
        }

        private static string[] gamers;
        public static void setGamers(int gamersCount)
        {
            gamers = new string[gamersCount];
        }

        public static int GameNumber { get; set; } // изначальная высота пирамиды
        private static int userTry = 4;             // значение шага по умолчанию
        public static int UserTry {
            get 
            {
                return userTry;
            } 
            set 
            {
                userTry = value;
            }
        } // величина шага userTry
        static void StartGame()
        {
            StartGame(false);
        }


        static void StartGame(bool revenge)
        {
            Random random = new Random();
            GameNumber = random.Next(20, 120);
            Clear();
            WriteLine("Вас приветствует игра Пирамида.");

            if (revenge)
            {
                printGamers();
            }
            else
            {
                newGamers();
            }

            WriteLine($"Высота пирамиды: {GameNumber}");

            setDifficultyGame();

            StartMoving();
        }

        private static void setDifficultyGame()
        {
            var inputPlace = new NewStruct(0, 0);
            WriteLine("Выберете сложность игры:");
            WriteLine("1 - стандартная игра, шаг от 1 до 4");
            WriteLine("2 - Ввести свой шаг");
            inputPlace.Item1 = CursorLeft;
            inputPlace.Item2 = CursorTop + 1;
            while (true)
            {
                bool gameDifficultChoose = int.TryParse(ReadKey().KeyChar.ToString(), out int gameDifficult);
                if (gameDifficultChoose)
                {
                    switch (gameDifficult)
                    {
                        case 1:
                            CursorLeft = 0;
                            return;
                        case 2:
                            CursorLeft = 0;
                            while (true)
                            {
                                Write("Введите максимальный размер шага, размер шага должен быть меньше высоты пирамиды: ");
                                bool isInt = int.TryParse(ReadLine(), out int stepSize);
                                if (isInt && stepSize >= 2)
                                {
                                    UserTry = stepSize;
                                    return;
                                }
                                else
                                {
                                    WriteLine("Неверный ввод. Повторите");
                                }
                            }
                        default:
                            break;
                    }
                }
                else
                {
                    SetCursorPosition(inputPlace.Item1, inputPlace.Item2 - 1);
                    Write("Неверный ввод. Повторите");
                    Write(new string(' ', WindowWidth));
                    SetCursorPosition(inputPlace.Item1, inputPlace.Item2);
                }
            }
        }

        private static void printGamers()
        {
            Clear();
            WriteLine("Итого участвуют игроки с никами:");
            foreach (var gamer in gamers)
            {
                WriteLine(gamer);
            }
            WriteLine(new string('-', WindowWidth));
        }

        private static void newGamers()
        {
            while (true)
            {
                Write("Введите количество игроков:");
                bool gamersCountIsInt = int.TryParse(ReadLine(), out int gamersCount);
                if (gamersCountIsInt)
                {
                    setGamers(gamersCount);
                    break;
                }
                else
                {
                    Write("Неверный ввод. Повторите");
                    SetCursorPosition(0, 1);
                    WriteLine(new string(' ', WindowWidth));
                    SetCursorPosition(0, 1);
                }
            }

            for (int i = 0; i < gamers.Length; i++)
            {
                gamers[i] = setGamersNicknames(i);
                WriteLine($"Игрок {i + 1} с ником {gamers[i]} успешно добавлен.");
            }

            WriteLine(new string('-', WindowWidth));

            printGamers();
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
                        Write($"Ходит игрок {gamers[i]}. Введи число от 1 до {UserTry}: ");
                        goodMove = int.TryParse(ReadLine(), out int step);
                        wrongEnter = !(goodMove && step >= 1 && step <= UserTry); // если правильный ввод, то выходим из цикала do while
                        if (goodMove && step >= 1 && step <= UserTry)
                        {
                            CursorLeft = 0;

                            gameNumberTmp = GameNumber - step;
                            if (gameNumberTmp <= 0)
                            {
                                WriteLine($"Победил игрок {gamers[i]}!!! Ура. Качай его, ребята!");
                                WriteLine("Новая игра - нажмите 1, Реванш(те же игроки) - нажмите 0, другая кнопка - выход.");
                                switch (ReadLine())
                                {
                                    case "0":
                                        StartGame(true);
                                        break;
                                    case "1":
                                        StartGame(false);
                                        break;
                                    default:
                                        return;
                                }
                            }
                            else
                            {
                                WriteLine($"Высота пирамиды {GameNumber} - {step} = {gameNumberTmp}.");
                                GameNumber = gameNumberTmp;
                            }
                            goodMove = false;
                        }
                        else
                        {
                            WriteLine("Неверный ввод!");
                            WriteLine();
                            continue;
                        }
                    }
                    while (wrongEnter);
                }
            }
        }
    }

    internal struct NewStruct
    {
        public int Item1;
        public int Item2;

        public NewStruct(int item1, int item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   Item1 == other.Item1 &&
                   Item2 == other.Item2;
        }

        public override int GetHashCode()
        {
            int hashCode = -1030903623;
            hashCode = hashCode * -1521134295 + Item1.GetHashCode();
            hashCode = hashCode * -1521134295 + Item2.GetHashCode();
            return hashCode;
        }

        public void Deconstruct(out int item1, out int item2)
        {
            item1 = Item1;
            item2 = Item2;
        }
    }
}
