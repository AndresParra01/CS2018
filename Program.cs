using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsayoRepaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto1 objeto1 = new Punto1();
            Punto1 objeto2 = new Punto1(3, 5);
            Punto1 objeto3 = new Punto1("Hola");

            Punto2 objeto4 = new Punto2(2, 3, 4, 5);

            Punto3 objeto5 = new Punto3(1, 2, 3, 4);

            Punto4 objeto6 = new Punto4();

            objeto2.x = 3;
            Punto1.y = 5;

            Console.WriteLine(objeto4.CalcularPromedio());
        }
    }
}
