using System;
using System.Collections.Generic;
using System.Text;

namespace _3PR_Lab_12_CSharp
{
    class SquareBaseBuilding : BuildingLayout
    {
		public SquareBaseBuilding() :base()
		{
		}
		public SquareBaseBuilding(double characteristic, double height, double weight) : base(characteristic, height, weight)
		{
		}
		public override double getVolume()
		{
			return characteristic * characteristic * height;
		}
	}
}
