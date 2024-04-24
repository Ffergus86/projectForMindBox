

namespace CalculationSquareLibrary.Models
{
    internal class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;
        private double square;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public double CalculateSquare()
        {
            var p = (_a + _b + _c) / 2;

            square = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));

            return square;
        }
    }
}
