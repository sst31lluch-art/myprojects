using System;
class MainClass {
	public static void Main (string [] args) {
	          Console.WriteLine("Welcome in my program");
		  Console.WriteLine("Would do you have to translate?");
		  string a = Convert.ToString(Console.ReadLine());
		  string b = Convert.ToString(Console.ReadLine());
		  int sum = Convert.ToInt32(Console.ReadLine());
		  if (a == "euro" && b == "rub"){
			  Console.WriteLine(sum/88);
		  }
		  else if (a == "rub" && b == "euro"){
			  Console.WriteLine(sum*88);
		  }
		  else if (a == "dol" && b == "rub"){
			  Console.WriteLine(sum/75);
		  }
		  else if (a == "rub" && b == "dol"){
			  Console.WriteLine(sum*75);
		  }
		  else if (a == "euro" && b == "dol"){
			  Console.WriteLine(sum*1.17);
		  }
		  else if (a == "dol" && b == "euro"){
			  Console.WriteLine(sum*0.85);
		  }
		  else{
			  Console.WriteLine("nope");
		  }
	}
}
