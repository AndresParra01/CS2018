using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, z, co, crad, h, Sa, Sb, p, a;

            Console.WriteLine("Ingrese el angulo inferior");
            c = Convert.ToDouble(Console.ReadLine());

            crad = c * Math.PI / 180;

            Console.ReadLine();

            Console.WriteLine("Ingrese el cateto adyacente");
            z = Convert.ToDouble(Console.ReadLine());

            Console.ReadLine();

            co = z / (Math.Tan(crad));
            Console.WriteLine("El cateto opuesto es:" + co);

            Console.ReadLine();

            h = Math.Sqrt((z * z + co * co));
            Console.WriteLine("La hipotenusa es:" + h);

            Console.ReadLine();

            p = z + co + h;
            Console.WriteLine("El perimetro es:" + p);

            Console.ReadLine();

            a = (z * co) / 2;
            Console.WriteLine("El area es:" + a);

            Console.ReadLine();

            Sa = z / h;
            Console.WriteLine("El SenA es:" + Sa);

            Console.ReadLine();

            Sb = co / h;
            Console.WriteLine("El SenB es:" + Sb);

            Console.ReadLine();
        }
    }
}
