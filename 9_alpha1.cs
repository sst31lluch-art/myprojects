using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в игру 'Виселица'");
        
        // 1. Инициализируем данные
        List<string> secretWords = new List<string> { "зигзаг", "еж", "щука", "фьорд", "эльф" };
        Random rand = new Random();
        int lives = 6;
        bool wordIsGuessed = false;
        bool isRunning = true;

        // 2. ВАЖНО: Сначала выбираем слово, потом создаем маску
        string secretWord = secretWords[rand.Next(secretWords.Count)];
        char[] display = new char[secretWord.Length];

        for (int i = 0; i < display.Length; i++)
        {
            display[i] = '*';
        }

        // 3. Цикл игры: пока есть жизни И слово не угадано И мы не вышли
        while (lives > 0 && !wordIsGuessed && isRunning)
        {
            Console.WriteLine("\nСлово: " + new string(display));
            Console.WriteLine($"Жизней: {lives}");
            Console.WriteLine("1. Ввести букву\n2. Выход");
            
            string answer = Console.ReadLine();

            if (answer == "2" || answer.ToLower() == "выход")
            {
                isRunning = false;
            }
            else
            {
                Console.Write("Введите букву: ");
                string input = Console.ReadLine().ToLower();
                if (string.IsNullOrEmpty(input)) continue; // Защита от пустого ввода
                
                char playerLetter = input[0];
                bool found = false;

                // Проверяем букву в слове
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == playerLetter)
                    {
                        display[i] = playerLetter;
                        found = true;
                    }
                }

                if (!found)
                {
                    lives--;
                    Console.WriteLine($"Буквы '{playerLetter}' нет!");
                }
                else
                {
                    Console.WriteLine("Есть такая буква!");
                }

                // Проверка на победу: остались ли еще звездочки?
                if (!new string(display).Contains("*"))
                {
                    wordIsGuessed = true;
                }
            }
        }

        // 4. Финал игры
        if (wordIsGuessed)
            Console.WriteLine($"\nПОБЕДА! Вы угадали слово: {secretWord}");
        else if (lives <= 0)
            Console.WriteLine($"\nПРОИГРЫШ! Секретное слово было: {secretWord}");
    }
}

