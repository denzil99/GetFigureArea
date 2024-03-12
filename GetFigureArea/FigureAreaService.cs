using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFigureArea
{
	public class FigureAreaService : IFigureAreaService
	{
		public double GetFigureArea(double val1,  double val2, double val3)
		{
			IFigure feagure = null;
			if (val2 == 0 ||  val3 == 0)
			{
				feagure = new Circle(val1);
				return feagure.Area;
			}

			feagure = new Triangle(val1, val2, val3);
			return feagure.Area;
			
		}


		public double GetTriangleArea(double sideA, double sideB, double sideC)
		{
			IFigure triangle = new Triangle(sideA, sideB, sideC);
			return triangle.Area;
		}

		public double GetCircleArea(double radius)
		{
			IFigure circle = new Circle(radius);
			return circle.Area;
		}
	}
}
