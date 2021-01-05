using System;
using System.Collections.Generic;
using System.Text;

namespace _3PR_Lab_12_CSharp
{
    class Garage
    {
		private double sideLength;
		private double sideWidth;
		private double height;

		public Garage()
		{
			sideLength = 1.0;
			sideWidth = 1.0;
			height = 1.0;
		}

		public Garage(double sideLength, double sideWidth, double height)
		{
			this.sideLength = sideLength;
			this.sideWidth = sideWidth;
			this.height = height;
		}
		// Функция по заданию приватных полей класса.
		public void setGarage(double sideLength, double sideWidth, double height)
		{
			this.sideLength = sideLength;
			this.sideWidth = sideWidth;
			this.height = height;
		}

		public void inputGarage()
		{
			Console.Write("Введите длину стороны гаража: ");
			while (!double.TryParse(Console.ReadLine(), out sideLength) || sideLength <= 0)
			{
				Console.WriteLine("Неверный ввод длины стороны - она должна быть неотрицательным числом. Попробуйте еще раз: ");
			}

			Console.Write("Введите ширину стороны гаража: ");
			while (!double.TryParse(Console.ReadLine(), out sideWidth) || sideWidth <= 0)
			{
				Console.WriteLine("Неверный ввод ширины стороны - она должна быть неотрицательным числом. Попробуйте еще раз: ");
			}

			Console.Write("Введите высоту гаража: ");
			while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
			{
				Console.WriteLine("Неверный ввод высоты - она должна быть неотрицательным числом. Попробуйте еще раз: ");
			}
			Console.WriteLine();
		}

		public void getGarage()
		{
			Console.WriteLine("Данные о гараже:");
			Console.WriteLine("Длина стороны гаража: " + sideLength);
			Console.WriteLine("Ширина стороны гаража: " + sideWidth);
			Console.WriteLine("Высота гаража: " + height);
		}

		public double getSideLength()
		{
			return sideLength;
		}

		public double getSideWidth()
		{
			return sideWidth;
		}

		public double getHeight()
		{
			return height;
		}
	}
}
