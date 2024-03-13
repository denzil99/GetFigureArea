using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//SELECT p.id, p.name as product, c.name AS category_name
//FROM Products p
//LEFT JOIN Categories c ON p.id = c.product_id
//ORDER BY p.id;

namespace GetFigureArea
{
	public class FigureAreaService : IFigureAreaService
	{
		public double GetFigureArea(double val1,  double val2, double val3)
		{
			IFigure figure = null;
			if (val2 == 0 ||  val3 == 0)
			{
				figure = new Circle(val1);
				return figure.Area;
			}

			figure = new Triangle(val1, val2, val3);
			return figure.Area;
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

		public bool CheckTriangleOnRightAngle(double sideA, double sideB, double sideC)
		{
			Triangle triangle = new Triangle(sideA, sideB, sideC);
			return triangle.IsRightAngeled;
		}
	}
}
