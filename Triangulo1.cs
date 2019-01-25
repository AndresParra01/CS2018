using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			double y, z, h, p, a, Sa, Sb;

			Console.WriteLine("ingrese el cateto opuesto");
			y = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("ingrese el cateto adyacente");
			z = Convert.ToDouble(Console.ReadLine());

			h = Math.Sqrt((y * y + z * z));
			Console.WriteLine("La hipotenusa es:" + h);

			Console.ReadLine();

			p = y + z + h;
			Console.WriteLine("El perimetro es:" + p);

			Console.ReadLine();

			a = (y * z)/2;
			Console.WriteLine("El area es:" + a);

			Console.ReadLine();

			Sa = z / h;
			Console.WriteLine("El SenA es:" + Sa);

			Console.ReadLine();

            
            Sb= y / h;
			Console.WriteLine("El SenB es:" + Sb);

		}
	}
}
