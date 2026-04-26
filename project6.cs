using System;
using System.Collections.Generic;
using System.Linq;

// Класс-чертеж предмета
public class Item
{
    public string Name;
    public int Price;
    public int Weight;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в инвентарь архитектора!");
        List<Item> inventory = new List<Item>();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nЧто вы хотите сделать?");
            Console.WriteLine("1. Показать все предметы");
            Console.WriteLine("2. Добавить свой предмет");
            Console.WriteLine("3. Удалить предмет из списка");
            Console.WriteLine("4. Выход");
            
            string otvet = Console.ReadLine();

            if (otvet.ToLower() == "выход" || otvet == "4")
            {
                isRunning = false;
            }
            else if (otvet.ToLower() == "показать все предметы" || otvet == "1")
            {
                Console.WriteLine("\nВот ваш инвентарь:");
                if (inventory.Count <= 0)
                {
                    Console.WriteLine("Список пока пуст");
                }

                foreach (Item item in inventory)
                {
                    Console.WriteLine($"Название: {item.Name}, Цена: {item.Price}, Вес: {item.Weight}");

                }
		if (inventory.Count > 0)
                {
                    var mostExpensive = inventory.OrderByDescending(x => x.Price).First();
                    Console.WriteLine($"Самый дорогой предмет: {mostExpensive.Name} ({mostExpensive.Price} золота)");
                }
            }
            else if (otvet.ToLower() == "добавить свой предмет" || otvet == "2")
            {
                Item newItem = new Item();

                Console.WriteLine("Введите название предмета:");
                newItem.Name = Console.ReadLine();

                Console.WriteLine("Введите вес предмета (число):");
                newItem.Weight = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите цену предмета (число):");
                newItem.Price = int.Parse(Console.ReadLine());

                inventory.Add(newItem);
                Console.WriteLine("Предмет успешно добавлен!");
            }
            else if (otvet.ToLower() == "удалить предмет из списка" || otvet == "3")
            {
                Console.WriteLine("Напишите название предмета для удаления:"); // Добавлена ;
                string nameToDelete = Console.ReadLine();

                // Исправлено: добавлены скобки () у ToLower и FirstOrDefault
                Item itemToRemove = inventory.FirstOrDefault(x => x.Name.ToLower() == nameToDelete.ToLower());

                if (itemToRemove != null)
                {
                    inventory.Remove(itemToRemove);
                    Console.WriteLine($"Предмет '{nameToDelete}' удален из инвентаря.");
                }
                else
                {
                    Console.WriteLine("Ошибка: Предмет с таким названием не найден.");
                }
            }
        } // Конец while
    } // Конец Main
} // Конец Program
