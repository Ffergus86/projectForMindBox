using CalculationSquareLibrary.Models;

namespace CalculationSquareLibrary.Factories
{
    internal class TriangleFactory : TypeFactory
    {

        private double _a;
        private double _b;
        private double _c;

        public TriangleFactory(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override IFigure GetTypeFactory()
        {
            Triangle figure = new Triangle(_a, _b, _c);
            return figure;
        }

    }
}
