namespace _2_я_практическая
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Игра 'угадай число!'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Делители числа");
            Console.WriteLine("4. Завершить работу");

            while (true)
            {
                Console.WriteLine("Выберите действие: ");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    Randomizer();
                    continue;
                }

                else if (a == 2)
                {
                    Tabl();
                    continue;
                }

                else if (a == 3)
                {
                    Deliteli();
                    continue;
                }

                else if (a == 4)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Вы ввели неверное значение! Пожалуйста, введите цифру от 1 до 4.");
                    continue;
                }
            }
        }

        static void Randomizer()
        {
            Random rnd = new Random();

            int random = rnd.Next(1, 100);

            Console.WriteLine("Введите число от 1 до 100");


            int nume = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (nume < random)
                {
                    Console.WriteLine("Слишком мало, попробуй ещё");
                    continue;
                }

                else if (nume > random)
                {
                    Console.WriteLine("Слишком много, попробуй поменьше");
                    continue;
                }

                else if (nume == random)
                {
                    Console.WriteLine("CONGRATULATIONS!!!! Вы угадали число!");
                    Console.WriteLine();
                    break;
                }
            }
        }

    

        static void Tabl()
        {
            int[,] table = new int[10, 10];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                table[i, 0] = i+1;

                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = (j + 1) * (i + 1);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Deliteli()
        {
            while (true)
            {
                Console.WriteLine("Введите целое число");
                Console.WriteLine("Чтобы вернуться в меню напишите слово 'выйти'");

                string b = Console.ReadLine();

                if (b == "выйти")
                {
                    break;
                }

                else
                {
                    int a = Convert.ToInt32(b);

                    for (int i = 1; i <= a; i++)
                    {
                        if (a % i == 0)
                        {
                            Console.Write(i + "\t");
                        }
                        else
                        {
                            continue;
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}