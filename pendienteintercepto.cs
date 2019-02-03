using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2, m, i, y;
            double d;

            Console.WriteLine("Ingrese la coordenada x1");
            x1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada x2");
            x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada y1");
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la coordenada y2");
            y2 = int.Parse(Console.ReadLine());

            m = (y2 - y1) / (x2 - x1);

            d = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            y = (m * -x1) + y1;
            
            Console.WriteLine("La pendiente es" + " " + m);

            Console.WriteLine("La distancia es" + " " + d);

            Console.WriteLine("El intercepto en y es" + " " + y);
        }
    }
}
