using System;
using System.Collections.Generic;
using System.Text;

namespace _3PR_Lab_12_CSharp
{
    class HouseWithGarage : Building
    {
		private Garage garage = new Garage();

		public HouseWithGarage() : base()
		{
			this.garage.setGarage(1.0, 1.0, 1.0);
		}
		public HouseWithGarage(string typeOfBuilding, double sideLength, double basementHeight,
			double floorHeight, int floorAmount, int windowsAmount, int openedWindowsAmount, double sideLengthG,
			double sideWidthG, double heightG) :base(typeOfBuilding, sideLength, basementHeight, floorHeight, floorAmount, windowsAmount, openedWindowsAmount)
		{
			this.garage.setGarage(sideLengthG, sideWidthG, heightG);
		}
		/* Функция по выводу свойств экземпляра класса Building. */
		public void get()
		{
			Console.WriteLine("Свойства данного здания:");
			Console.WriteLine("Название строительной компании: " + companyName);
			Console.WriteLine("Общее количество зданий этой компании: " + countOfBuildings);
			Console.WriteLine("Тип здания: " + typeOfBuilding);
			Console.WriteLine("Длина стороны основания: " + sideLength);
			Console.WriteLine("Высота фундамента: " + basementHeight);
			Console.WriteLine("Высота этажа: " + floorHeight);
			Console.WriteLine("Количество этажей: " + floorAmount);
			facade.getFacade();
			Console.WriteLine("Коэффициент устойчивости: " + stabilityFactor);
			garage.getGarage();
			Console.WriteLine();
		}

		public void input()
		{
			base.input();
			garage.inputGarage();
		}

        public override string ToString()
        {
			string s = "";
			s += "Свойства данного здания:\n" + "Название строительной компании: " +
				Convert.ToString(companyName) + "\nОбщее количество зданий этой компании: " +
				Convert.ToString(countOfBuildings) + "\nТип здания: " + Convert.ToString(typeOfBuilding) +
				"\nДлина стороны основания: " + Convert.ToString(sideLength) + "\nВысота фундамента: " +
				Convert.ToString(basementHeight) + "\nВысота этажа: " + Convert.ToString(floorHeight) +
				"\nКоличество этажей: " + Convert.ToString(floorAmount) + "\nОбщее количество окон: " +
				Convert.ToString(facade.getWindowsAmount()) + "\nКоличество открытых окон: " +
				Convert.ToString(facade.getOpenedWindowsAmount()) + "\nКоэффициент устойчивости: " +
				Convert.ToString(stabilityFactor) + "\nДанные о гараже:\nДлина стороны гаража: " +
				Convert.ToString(getSideLength()) + "\nШирина стороны гаража: " +
				Convert.ToString(getSideWidth()) + "\nВысота гаража: " + Convert.ToString(getHeight()) + "\n";
			return s;
		}

        double getVolume()
		{
			return (sideLength * sideLength * floorHeight * floorAmount) +
				(getSideLength() * getSideWidth() * getHeight());
		}

		void getGarage()
		{
			garage.getGarage();
		}

		double getSideLength()
		{
			return garage.getSideLength();
		}

		double getSideWidth()
		{
			return garage.getSideWidth();
		}

		double getHeight()
		{
			return garage.getHeight();
		}
	}
}
