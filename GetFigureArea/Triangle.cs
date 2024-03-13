using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFigureArea
{
	/// <summary>
	/// Представляет данные о треугольнике
	/// </summary>
	public class Triangle : IFigure
	{
		#region Properties
		/// <summary>
		/// Возвращает сторону А
		/// </summary>
		public double SideA { get; private set; }
		/// <summary>
		/// Возвращает сторону B
		/// </summary>
		public double SideB { get; private set; }
		/// <summary>
		/// Возвращает сторону C
		/// </summary>
		public double SideC { get; private set; }
		/// <summary>
		/// Возвращает площщадь круга
		/// </summary>
		public double Area
		{
			get
			{
				return Math.Sqrt(Perimetr * (Perimetr - SideA) * (Perimetr - SideB) * (Perimetr - SideC));
			}
		}
		/// <summary>
		/// Возвращает периметр круга
		/// </summary>
		public double Perimetr
		{
			get
			{
				return (SideA + SideB + SideC) / 2;
			}
		}
		/// <summary>
		/// Возвращает true, если прямоугольник прямоугольный
		/// </summary>
		public bool IsRightAngeled
		{
			get
			{
				//Эх, надо было через инты всё делать...
				if (Math.Round(Math.Pow(SideA, 2), 3) == (Math.Round(Math.Pow(SideB, 2), 3) + Math.Round(Math.Pow(SideC, 2), 3))) 
					return true;
				else if (Math.Round(Math.Pow(SideB, 2), 3) == (Math.Round(Math.Pow(SideA, 2), 3) + Math.Round(Math.Pow(SideC, 2), 3)))
					return true;
				else if (Math.Round(Math.Pow(SideC, 2), 3) == (Math.Round(Math.Pow(SideB, 2), 3) + Math.Round(Math.Pow(SideA, 2), 3)))
					return true;
				return false;
			}
		}
		#endregion

		#region .ctor
		public Triangle(double sideA, double sideB, double sideC)
		{
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}
		#endregion
	}
}
