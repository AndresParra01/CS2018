using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFactorizar
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x, x1, x2;

            Console.WriteLine("ingrese a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("ingrese b:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("ingrese c:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.ReadLine();

            d = b * b - 4 * a * c;               //Si el discriminante es negativo, no hay soluciones

            if (d < 0)
            {
                Console.ReadLine("La ecuacion no es valida");

            }
            else
            {
                if(d == 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);

                    x2 = (-b - Math.Sqrt(d)) / (2 * a);

                    Console.ReadLine("" + x);
                }
                else
                {
                    x1 = (-b - (d * )) / (2 * a);

                    x2 = (-b + (d* )) / (2 * a);

                    Console.ReadLine("X1:" + x1);

                    Console.ReadLine();

                    Console.ReadLine("X2:" + x2);
                }
            }
        }
    }
}
