using CalculationSquareLibrary.Models;

namespace CalculationSquareLibrary.Factories
{
    internal class RectangleFactory : TypeFactory
    {

        private double _a;
        private double _b;
        private double _c;

        public RectangleFactory(double a, double b)
        {
            _a = a;
            _b = b;

        }

        public override IFigure GetTypeFactory()
        {
            Rectangle figure = new Rectangle(_a, _b);
            return figure;
        }

    }
}
