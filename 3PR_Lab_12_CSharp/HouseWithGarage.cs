using System;
using System.Collections.Generic;
using System.Text;

namespace _3PR_Lab_12_CSharp
{
    class HouseWithGarage : Building
    {
		private Garage garage;

		public HouseWithGarage()
		{
			this.garage.setGarage(1.0, 1.0, 1.0);
		}
		public HouseWithGarage(string typeOfBuilding, float sideLength, float basementHeight,
			float floorHeight, int floorAmount, int windowsAmount, int openedWindowsAmount, float sideLengthG,
			float sideWidthG, float heightG) :base(typeOfBuilding, sideLength, basementHeight, floorHeight, floorAmount, windowsAmount, openedWindowsAmount)
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
