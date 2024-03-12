using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFigureArea
{
	public interface IFigure
	{
		/// <summary>
		/// Возвращает площадь фигуры
		/// </summary>
		double Area { get; }
	}
}
