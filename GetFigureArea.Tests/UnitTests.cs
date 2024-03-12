namespace GetFigureArea.Tests
{
	public class Tests
	{
		private IFigureAreaService _figureAreaService;

		[SetUp]
		public void SetUp()
		{
			_figureAreaService = new FigureAreaService();
		}


		[Test]
		public void GetCircleAreaTest()
		{
			double radius = 5.5;
			double expected = 190.066;


			double result = _figureAreaService.GetCircleArea(radius);
			Assert.AreEqual(expected, Math.Round(result, 3));
		}

		[Test]
		public void GetTriangleAreaTest()
		{
			double sideA = 5;
			double sideB = 6;
			double sideC = 7;
			double expected = 14.697;


			double result = _figureAreaService.GetTriangleArea(sideA, sideB, sideC);
			Assert.AreEqual(expected, Math.Round(result, 3));
		}
	}
}