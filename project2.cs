using System;

class Program
{
    // Поле игры: 9 ячеек, заполненных цифрами-подсказками
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1; // 1 — это Крестики, 2 — Нолики

    static void Main(string[] args)
    {
        int choice; // Переменная для выбора игрока
        bool gameRunning = true;

        do
        {
            Console.Clear();
            Console.WriteLine("Игрок 1: X и Игрок 2: O");
            Console.WriteLine("\n");
            DrawBoard(); // Отрисовка поля

            // Определяем символ текущего игрока
            char playerSymbol = (currentPlayer % 2 != 0) ? 'X' : 'O';
            Console.WriteLine($"\nХод игрока {((currentPlayer % 2 != 0) ? "1" : "2")} ({playerSymbol}). Введите номер клетки:");

            // Проверка ввода
            bool isValidInput = int.TryParse(Console.ReadLine(), out choice);

            if (isValidInput && choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O')
            {
                board[choice - 1] = playerSymbol; // Ставим символ на поле
                
                int winStatus = CheckWin(); // Проверяем состояние игры

                if (winStatus == 1) // Есть победитель
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine($"\nПобедил игрок {((currentPlayer % 2 != 0) ? "1" : "2")}!");
                    gameRunning = false;
                }
                else if (winStatus == -1) // Ничья
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine("\nНичья!");
                    gameRunning = false;
                }
                else
                {
                    currentPlayer++; // Переход хода
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Клетка занята или введено неверное число. Нажмите Enter и попробуйте снова.");
                Console.ReadLine();
            }

        } while (gameRunning);

        Console.WriteLine("Игра окончена. Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }

    // Метод отрисовки сетки
    static void DrawBoard()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {board[0]}  |  {board[1]}  |  {board[2]}   ");
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {board[3]}  |  {board[4]}  |  {board[5]}   ");
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine($"  {board[6]}  |  {board[7]}  |  {board[8]}   ");
        Console.WriteLine("     |     |      ");
    }

    // Метод проверки победы
    // 1  - есть победитель, -1 - ничья, 0 - игра продолжается
    static int CheckWin()
    {
        // Выигрышные комбинации (горизонтали, вертикали, диагонали)
        int[,] winners = {
            {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // Горизонтали
            {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // Вертикали
            {0, 4, 8}, {2, 4, 6}             // Диагонали
        };

        for (int i = 0; i < 8; i++)
        {
            if (board[winners[i, 0]] == board[winners[i, 1]] && board[winners[i, 1]] == board[winners[i, 2]])
                return 1;
        }

        // Проверка на ничью (если не осталось цифр)
        foreach (char c in board)
        {
            if (c != 'X' && c != 'O') return 0;
        }

        return -1;
    }
}

