using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work5
{
    class Triangulo
    {
        public string Tipo;
        public double[] Lados = new double[6];
        public bool v;

        public void Validar()
        {
            if (Lados[3] < 3 || Lados[3] > 3 || (Lados[0] + Lados[1]) < Lados[2] || (Lados[1] + Lados[2]) < Lados[0] || (Lados[0] + Lados[2]) < Lados[1])
            {
                Console.WriteLine("Ha ocurrido un error, ingrese un triangulo valido");
            }
        }

        public void Calcular()
        {
            if(Lados[0] - Lados[1] == 0 && Lados[1] - Lados[2] == 0 && Lados[0] - Lados[2] == 0)
            {
                Console.WriteLine("El triangulo es equilatero");
                Tipo = Console.ReadLine();
            }
            else if(Lados[0] - Lados[1] == 0 || Lados[1] - Lados[2] == 0 || Lados[0] - Lados[2] == 0)
                {
                    Console.WriteLine("El triangulo es isosceles");
                    Tipo = Console.ReadLine();
                }
            else
            {
                    Console.WriteLine("El triangulo es escaleno");
                    Tipo = Console.ReadLine();
            }
            }
        }
    }

