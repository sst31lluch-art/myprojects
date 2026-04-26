using System;

class Program
{
	static void Main(string[] args)
	{
             Random rand = new Random();
             int secret = rand.Next(1,101);
	     for (int i = 1; i<=10;i++)
	     {
                  Console.WriteLine($"Попытка №{i}.Введите число: ");
		  int number = Convert.ToInt32(Console.ReadLine());
		  if (number == secret)
		  {
			  Console.WriteLine("Поздравляю");
			  break;
		  }
		  else if (number<secret)
		  {
			  Console.WriteLine("Мое число больше.Попробуй снова");
		  }
		  else if (number>secret)
		  {
			  Console.WriteLine("Мое число меньше.Попробуй снова");
		  }	  
	     }
        }
}
