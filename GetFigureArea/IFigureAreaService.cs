namespace GetFigureArea
{
	public interface IFigureAreaService
	{
		/// <summary>
		/// Возвращает площадь треугольника
		/// </summary>
		/// <param name="sideA">Сторона А</param>
		/// <param name="sideB">Сторона B</param>
		/// <param name="sideC">Сторона C</param>
		/// <returns></returns>
		double GetTriangleArea(double sideA, double sideB, double sideC);
		/// <summary>
		/// Возвращает площадь круга
		/// </summary>
		/// <param name="radius">Радиус круга</param>
		/// <returns></returns>
		public double GetCircleArea(double radius);
	}
}