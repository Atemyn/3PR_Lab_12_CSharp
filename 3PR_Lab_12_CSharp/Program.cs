using System;
using System.Collections.Generic;

namespace _3PR_Lab_12_CSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Работа с производным классом. */
			HouseWithGarage house1 = new HouseWithGarage();
			house1.input();
			house1.get();

			HouseWithGarage house2 = new HouseWithGarage("Коттедж", 5.0, 1.0, 3.0, 5, 5, 5, 1.0, 2.0, 3.0);
			Console.WriteLine(house2);
			// Разумное использование виртуальной функции.
			// Объем равен 375. 
			Building b1 = new Building("Коттедж", 5.0, 1.0, 3.0, 5, 5, 5);
			// Объем равен 376.
			HouseWithGarage h1 = new HouseWithGarage("Коттедж", 5.0, 1.0, 3.0, 5, 5, 5, 1.0, 1.0, 1.0);
			bool f1, f2;
			f1 = b1.volumeLessThan(375.0);
			f2 = h1.volumeLessThan(375.0);
			Console.WriteLine("f1 = " + f1);
			Console.WriteLine("f2 = " + f2 + "\n");
			/*...............................*/
		}
	}
}