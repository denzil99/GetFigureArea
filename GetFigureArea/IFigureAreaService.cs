namespace GetFigureArea
{
	public interface IFigureAreaService
	{
		/// <summary>
		/// Возвращает площадь фигуры, в зависимости от переданных параметров
		/// </summary>
		/// <param name="val1">Значение 1, не может равняться нулю</param>
		/// <param name="val2">Значение 2, если не требуется, ставится ноль</param>
		/// <param name="val3">Значение 3, если не требуется, ставится ноль</param>
		/// <returns>Возвращает площадь фигуры</returns>
		double GetFigureArea(double val1, double val2, double val3);
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
		/// <summary>
		/// Возвращает true, если прямоугольник прямоугольный
		/// </summary>
		/// <param name="sideA">Сторона А</param>
		/// <param name="sideB">Сторона B</param>
		/// <param name="sideC">Сторона C</param>
		/// <returns></returns>
		public bool CheckTriangleOnRightAngle(double sideA, double sideB, double sideC);
	}
}