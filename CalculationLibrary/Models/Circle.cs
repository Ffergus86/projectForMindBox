

namespace CalculationSquareLibrary.Models
{
    internal class Circle : IFigure
    {
        private double _radius;
        private double square;

        public Circle(double radius) 
        {
            _radius = radius;
        }

        public double CalculateSquare()
        {
            square = Math.PI * _radius * _radius;
            return square;
        }
    }
}
