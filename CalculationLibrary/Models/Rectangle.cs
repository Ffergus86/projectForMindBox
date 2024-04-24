

namespace CalculationSquareLibrary.Models
{
    internal class Rectangle : IFigure
    {
        private double _a;
        private double _b;
        private double square;

        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
        }
        public double CalculateSquare()
        {
            square = _a * _b;

            return square;
        }
    }
}
