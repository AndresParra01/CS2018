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
            double co, ca, h, a, ai, sa, sb, Asrad, Airad, P, A;

            Console.WriteLine("ingrese la hipotenusa");
            h = Convert.ToDouble(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("ingrese el angulo superior");
            a = Convert.ToDouble(Console.ReadLine());

            Asrad = a * Math.PI / 180;

            Console.ReadLine();

            ai = 90 - a;
            Console.WriteLine("El angulo inferior es" + ai);

            Airad = ai * Math.PI / 180;

            Console.ReadLine();

            co = h * (Math.Sin(Asrad));
            Console.WriteLine("El cateto opuesto es:" + co);

            Console.ReadLine();

            ca = h * (Math.Cos(Airad));
            Console.WriteLine("El cateto adyacente es:" + ca);

            Console.ReadLine();

            P = ca + co + h;
            Console.WriteLine("El perimetro es:" + P);

            Console.ReadLine();

            A = (ca * co) / 2;
            Console.WriteLine("El area es:" + A);

            Console.ReadLine();

            sa = ca / h;
            Console.WriteLine("El SenA es:" + sa);

            Console.ReadLine();

            sb = co / h;
            Console.WriteLine("El SenB es:" + sb);

        }
    }
}
