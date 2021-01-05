using System;
using System.Collections.Generic;

namespace _3PR_Lab_12_CSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Использование одномерных и двумерных массивов. */
			Console.WriteLine("Использование одномерных и двумерных массивов:");
			const int N = 7;
			Building[] array1 = new Building[N];
			for (int i = 0; i < N; i++)
			{
				array1[i] = new Building();
			}
			Building.array1Forming(array1, N);
			Console.WriteLine("Длины сторон получившихся зданий одномерного массива:");
			Building.array1Output(array1, N);

			const int M = 3;
			Building[,] array2 = new Building[N, M];
			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < M; j++)
				{
					array2[i, j] = new Building();
				}
			}
			Building.array2Forming(array2, N, M);
			Console.WriteLine("Длины сторон получившихся зданий двумерного массива:");
			Building.array2Output(array2, N, M);
			/*................................................*/
		}
	}
}