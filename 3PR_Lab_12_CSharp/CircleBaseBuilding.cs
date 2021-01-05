using System;
using System.Collections.Generic;
using System.Text;

namespace _3PR_Lab_12_CSharp
{
    class CircleBaseBuilding: BuildingLayout
    {
		public CircleBaseBuilding(double characteristic, double height, double weight) : base(characteristic, height, weight)
		{
		}
		public CircleBaseBuilding() :base()
		{
		}
		public override double getVolume()
		{
			return Math.PI * characteristic * characteristic * height +
				2.0 / 3.0 * Math.PI * characteristic * characteristic * characteristic;
		}
	}
}
