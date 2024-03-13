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

		[Test]
		public void GetFigureTriangleAreaTest()
		{
			double val1 = 5;
			double val2 = 6;
			double val3 = 7;
			double expected = 14.697;


			double result = _figureAreaService.GetFigureArea(val1, val2, val3);
			Assert.AreEqual(expected, Math.Round(result, 3));
		}

		[Test]
		public void GetFigureCircleAreaTest()
		{
			double val1 = 5.5;
			double val2 = 0;
			double val3 = 0;
			double expected = 190.066;


			double result = _figureAreaService.GetFigureArea(val1, val2, val3);
			Assert.AreEqual(expected, Math.Round(result, 3));
		}

		[Test]
		public void CheckIfRightAngeledTest()
		{
			double val1 = 6;
			double val2 = 10;
			double val3 = 8;
			bool expected = true;


			var result = _figureAreaService.CheckTriangleOnRightAngle(val1, val2, val3);
			Assert.AreEqual(expected, result);
		}
	}
}