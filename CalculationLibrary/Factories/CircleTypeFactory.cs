using CalculationSquareLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationSquareLibrary.Factories
{
    internal class CircleTypeFactory : TypeFactory
    {
        private readonly double _radius;

        public CircleTypeFactory(double radius)
        {
            _radius = radius;
        }

        public override IFigure GetTypeFactory()
        {
            Circle figure = new Circle(_radius);
            return figure;
        }
    }
}
