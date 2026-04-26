using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        int currentTask = 0;
        Random rand = new Random(); // Создаем один раз в начале
        Console.WriteLine("Добро пожаловать в математическую игру");

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nВыберите что вы хотите сделать");
            Console.WriteLine("1. Играть \n2. Выйти");
            string action = Console.ReadLine();

            if (action.ToLower() == "выйти" || action == "2" || action.ToLower() == "выход")
            {
                isRunning = false;
            }
            else if (action == "1")
            {
                Console.WriteLine("Сколько примеров ты хочешь решить?");
                int maxTask = int.Parse(Console.ReadLine());

                Console.WriteLine("Какая сложность? (Введите максимальное число, например 10 или 100)");
                // ИСПРАВЛЕНО: Читаем через ReadLine
                int limit = Convert.ToInt32(Console.ReadLine()); 

                currentTask = 0; // Сбрасываем счетчик перед новой игрой
                score = 0;

                while (currentTask < maxTask)
                {
                    currentTask++;
                    // ИСПРАВЛЕНО: Генерируем числа ТУТ, чтобы они были разными
                    int a = rand.Next(1, limit + 1);
                    int b = rand.Next(1, limit + 1);
                    int correctAnswer;

                    Console.WriteLine($"\nПример № {currentTask}");
                    int plusorminus = rand.Next(0, 2);

                    if (plusorminus == 0)
                    {
                        correctAnswer = a + b;
                        Console.Write($"{a} + {b} = "); // Используем Write, чтобы ответ был в той же строке
                    }
                    else
                    {
                        if (a < b) { int temp = a; a = b; b = temp; }
                        correctAnswer = a - b;
                        Console.Write($"{a} - {b} = ");
                    }

                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int userAnswer))
                    {
                        if (userAnswer == correctAnswer)
                        {
                            Console.WriteLine("Правильно! +1 балл");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine($"Ошибка! Правильный ответ: {correctAnswer}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Пожалуйста, введите число!");
                    }
                }
                Console.WriteLine($"\nТренировка закончена! Ваш счет: {score} из {maxTask}");
            }
        }
    }
}

