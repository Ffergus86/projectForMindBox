using CalculationSquareLibrary;



namespace TestСCalculationSquare
{
    public class CalculationSquareTestСircle
    {
        private CalculationSquare _figure;

        [SetUp]
        public void Setup()
        {
            _figure = new CalculationSquare(2);
        }

        [Test]
        public void GetSquare_EqualTest()
        {
            double correctAnswer = 12.566370614359172;

            var square = _figure.GetSquare();

            Assert.AreEqual(correctAnswer, square);
        }
    }

    public class CalculationSquareTestTrangle
    {
        private CalculationSquare _figure;

        [SetUp]
        public void Setup()
        {
            _figure = new CalculationSquare(5, 5, 5);
        }

        [Test]
        public void GetSquare_EqualTest()
        {
            double correctAnswer = 10.825317547305483;

            var square = _figure.GetSquare();

            Assert. AreEqual(correctAnswer, square);
        }
    }

    public class CalculationSquareTestRectangle
    {
        private CalculationSquare _figure;

        [SetUp]
        public void Setup()
        {
            _figure = new CalculationSquare(4, 4);
        }

        [Test]
        public void GetSquare_EqualTest()
        {
            double correctAnswer = 16;

            var square = _figure.GetSquare();

            Assert.AreEqual(correctAnswer, square);
        }
    }
}