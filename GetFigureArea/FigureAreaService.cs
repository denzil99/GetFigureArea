using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFigureArea
{
	public class FigureAreaService : IFigureAreaService
	{

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
