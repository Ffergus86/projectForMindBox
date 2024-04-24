using CalculationSquareLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationSquareLibrary.Factories
{
    internal abstract class TypeFactory
    {
        public abstract IFigure GetTypeFactory();
    }
}
