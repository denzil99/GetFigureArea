namespace GetFigureArea
{
	/// <summary>
	/// Представляет данные о круге
	/// </summary>
	public class Circle : IFigure
	{
		#region Properties
		/// <summary>
		/// Возвращает число Pi
		/// </summary>
		private double Pi
		{
			get
			{
				return Math.PI;
			}
		}

		/// <summary>
		/// Возвращает радиус
		/// </summary>
		public double Radius { get; private set; }

		/// <summary>
		/// Возвращает площадь круга
		/// </summary>
		public double Area
		{
			get
			{
				return 2 * Pi * Math.Pow(Radius, 2);
			}
		}
		#endregion

		#region .ctor
		public Circle(double radius)
		{
			Radius = radius;
		} 
		#endregion
	}
}
