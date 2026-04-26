using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Магический шар приветствует тебя");

		List<string> answers = new List<string>{ "Спроси позже" , "Скорее нет , чем да" , "Звезды говорят - ДА!" , "Даже не думай" , "Возможно частично" , "Послушай себя" , "Повтори запрос"};

		Random rand = new Random();

		bool isRunning = true;
                
		while(isRunning)
		{
                        int index = rand.Next(answers.Count);
			Console.WriteLine("Что вы ходите сделать?");
			Console.WriteLine("1. Написать запрос");
			Console.WriteLine("2. Выход");
			string promt = Console.ReadLine();
			if (promt.ToLower() == "написать запрос" || promt == "1" )
			{
				Console.Clear();
				Console.WriteLine("Введите запрос ...");
				Console.ReadLine();
				Console.WriteLine(answers[index]);
			}
			else if (promt.ToLower() == "выход" || promt == "2")
			{
				Console.Clear();
				Console.WriteLine("Магический шар желает вам удачи!");
				isRunning = false;
			}
			else
			{
				Console.WriteLine("Ошибка: \nНеверный синтаксис");
			}
		}
	}
}
