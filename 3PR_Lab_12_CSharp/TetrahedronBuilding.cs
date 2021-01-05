using System;
using System.Collections.Generic;
using System.Text;

namespace _3PR_Lab_12_CSharp
{
    class TetrahedronBuilding : BuildingLayout
    {
		public TetrahedronBuilding() : base()
		{
		}
		public TetrahedronBuilding(double characteristic, double height, double weight) : base(characteristic, height, weight)
		{
		}
		public override double getVolume()
		{
			return characteristic * characteristic * characteristic * Math.Sqrt(2.0) / 12;
		}
	}
}
