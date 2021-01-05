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
			/*...............................*/
		}
	}
}