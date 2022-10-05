using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjFiguras
{
    public class Circulo : FiguraBidimensional
    {
        public Circulo(double lado, double radio, double basee, double altura) : base(lado, radio, basee, altura)
        {
        }
        public override double CalcularArea() 
        {
            CalcularArea = Math.PI * (Radio * 2);
        }
        
            
        
    }
    


}
