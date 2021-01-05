using System;
using System.Collections.Generic;

namespace _3PR_Lab_12_CSharp
{
	class Program
	{
		static void Launch(object obj)
		{
			InterfaceFlyable flyable = obj as InterfaceFlyable;
			if (flyable != null)
			{
				flyable.Fly();
			}
			else
			{
				Console.WriteLine("Объект типа " + obj.GetType() + " не может полететь.");
			}
		}

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
			// Производные классы от абстрактного класса.
			SquareBaseBuilding s = new SquareBaseBuilding(5.0, 10.0, 1000.0);
			CircleBaseBuilding c = new CircleBaseBuilding(5.0, 10.0, 1000.0);
			TetrahedronBuilding t = new TetrahedronBuilding(5.0, 10.0, 1000.0);
			Console.WriteLine("Здание с квадратным основанием:" + "\nОбъем: " + s.getVolume() + "\nПлотность: " + s.getDensity() + "\n");
			Console.WriteLine("Здание с круглым основанием:" + "\nОбъем: " + c.getVolume() + "\nПлотность: " + c.getDensity() + "\n");
			Console.WriteLine("Здание-тетраэдр:" + "\nОбъем: " + t.getVolume() + "\nПлотность: " + t.getDensity() + "\n");
			// Разумное использование интерфейса.
			Plane plane = new Plane("Люкс-1892");
			Rock rock = new Rock();
			string testStr = "Могу ли я полететь?";
			int testInt = 401;

			Launch(plane);
			Launch(rock);
			Launch(testStr);
			Launch(testInt);
			// Глубокое копирование.
			HouseWithGarage hg1 = new HouseWithGarage("Коттедж", 5.0, 1.0, 3.0, 5, 5, 5, 1, 2, 3);
			HouseWithGarage hg2 = new HouseWithGarage("Коттедж", 5.0, 1.0, 3.0, 5, 4, 4, 5, 6, 7);

			hg1 = (HouseWithGarage)hg2.Clone();
			hg2.input();
			Console.WriteLine("hg1 = \n" + hg1);
			/*...............................*/
		}
	}
}