using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjFiguras
{
    internal class FiguraTridimensional : Figuras
    {
        public FiguraTridimensional(double lado, double radio, double basee, double altura) : base(lado, radio, basee, altura)
        {
        }

        public override double CalcularArea()
        {
            throw new NotImplementedException();
        }

        public override double CalcularPerimetro()
        {
            throw new NotImplementedException();
        }

        public override double CalcularVolumen()
        {
            throw new NotImplementedException();
        }
    }
}
