using System;

class Program
{
	static void Main(string[] args)
	{	
		Console.WriteLine("Рады вас видеть в нашем гей-клубе Голубой Шампур");
		Console.WriteLine("Как вас зовут?");
		string name = Convert.ToString(Console.ReadLine());
		Console.WriteLine("В каком году вы родились?");
		int year = Convert.ToInt32(Console.ReadLine());
		int age = (2026-year);
		if (age<=17)
		{
			Console.WriteLine("Извините "+name," вам еще рано сюда заходить");
		}
		else
		{
			Console.WriteLine("Добро пожаловать "+name);
		}

	}
}
