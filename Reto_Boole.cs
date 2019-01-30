using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_reto
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, blancos, anulados, n, vtotales;
            double p, pobvotante;

            Console.WriteLine("Ingrese el numero de votos por el partido 1");
            a = int.Parse(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("Ingrese el numero de votos por el partido 2");
            b = int.Parse(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("Ingrese numero de votos en blanco");
            blancos = int.Parse(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("Ingrese el numero de votos anulados");
            anulados = int.Parse(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("Ingrese el numero total de la poblacion");
            n = int.Parse(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("Ingrese el porcentaje de la poblacion mayor de edad");
            p = Convert.ToDouble(Console.ReadLine());

            Console.ReadLine();

            pobvotante = (n * p) / 100;

            vtotales = a + b + blancos;

            bool x = vtotales > pobvotante;
            bool y = Math.Abs(a -b) < (vtotales * 10) / 100; 
            bool z = vtotales < (pobvotante * 30) / 100;

            if(x || (y && z))
            {
                Console.WriteLine("Las elecciones deben ser ejecutadas nuevamente");
            }  

            if(a > b)
            {
                Console.WriteLine("El ganador de las elecciones es el partido 1");
            }
            else
            {
                if(b > a)
                {
                    Console.WriteLine("El ganador de las elecciones es el partido 2");
                }
            }
        }
    }
}




/*CONDICION 1  v  CONDICION 2  ^  CONDICION 3     SALIDA
 * 0                0               0               0
 * 0                0               1               0
 * 0                1               0               0
 * 0                1               1               1
 * 1                0               0               0
 * 1                0               1               1
 * 1                1               0               0
 * 1                1               1               1
 
1 =v, 0 =f
 */
