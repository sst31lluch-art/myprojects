using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в инвентарь!");
        List<string> inventory = new List<string>();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nЧто вы хотите сделать?");
            Console.WriteLine("1. Показать все предметы");
            Console.WriteLine("2. Добавить свой предмет");
            Console.WriteLine("3. Удалить предмет из списка");
            Console.WriteLine("4. Выход");

            string otvet = Console.ReadLine(); // Convert.ToString тут не нужен, ReadLine и так дает строку

            // Используем ToLower(), чтобы не писать три раза "выход", "ВЫХОД" и т.д.
            if (otvet.ToLower() == "выход" || otvet == "4")
            {
                isRunning = false;
            }
            else if (otvet.ToLower() == "показать все предметы" || otvet == "1")
            {
                Console.WriteLine("\nВаш инвентарь:");
                if (inventory.Count == 0)
                {
                    Console.WriteLine("Список пока пуст");
                }
                foreach (string item in inventory)
                {
                    Console.WriteLine("- " + item);
                }
            }
            else if (otvet.ToLower() == "добавить свой предмет" || otvet == "2")
            {
                Console.WriteLine("Введите название предмета:");
                string predmet = Console.ReadLine();
                inventory.Add(predmet);
                
                Console.WriteLine("Вот ваш список теперь:");
                foreach (string item in inventory) // ИСПРАВЛЕНО: foreach вместо forech
                {
                    Console.WriteLine("- " + item);
                }
            }
            else if (otvet.ToLower() == "удалить свой предмет из списка" || otvet == "3")
            {
                Console.WriteLine("Напишите предмет, который вы хотите удалить:");
                string del = Console.ReadLine();
                
                if (inventory.Contains(del))
                {
                    inventory.Remove(del);
                    Console.WriteLine($"Товар '{del}' успешно удален.");
                }
                else
                {
                    Console.WriteLine("Ошибка: Предмета нет в инвентаре");
                }
            }
        } // Конец while
    } // Конец Main
} // Конец class



















