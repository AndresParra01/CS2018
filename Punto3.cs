using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsayoRepaso
{
    class Punto3: Punto2
    {
        public Punto3(double m, double n, double o, double p): base (m, n, o, p)
        {

        }
        public override double CalcularPromedio()
        {
            double promedio = (valor3 + valor4) / 2;
            return promedio;
        }
    }
}
