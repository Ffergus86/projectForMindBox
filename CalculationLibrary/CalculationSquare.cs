using CalculationSquareLibrary.Factories;

namespace CalculationSquareLibrary
{
    public class CalculationSquare
    {
        private readonly TypeFactory _type;
        public CalculationSquare(double a) 
        {
            _type = new CircleTypeFactory(a);
        }

        public CalculationSquare(double a, double b)
        {
            _type = new RectangleFactory(a, b);
        }

        public CalculationSquare(double a, double b, double c)
        {
            _type = new TriangleFactory(a, b, c);
        }


        public double GetSquare()
        {
            var figure = _type.GetTypeFactory();
            var res = figure.CalculateSquare();
            return res;
          
        }
    }
}
