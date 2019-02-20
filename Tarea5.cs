using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work5
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo0 = new Triangulo();
            Console.WriteLine("Ingrese el lado 1");
            triangulo0.Lados[0] = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 2");
            triangulo0.Lados[1] = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 3");
            triangulo0.Lados[2] = Double.Parse(Console.ReadLine());
            triangulo0.Validar();
            triangulo0.Calcular();
            Console.WriteLine("El triangulo es: " + triangulo0.Tipo);

            Triangulo triangulo1 = new Triangulo();
            Console.WriteLine("Ingrese el lado 1");
            triangulo0.Lados[3] = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 2");
            triangulo0.Lados[4] = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el lado 3");
            triangulo0.Lados[5] = Double.Parse(Console.ReadLine());
            triangulo0.Validar();
            triangulo0.Calcular();
            Console.WriteLine("El triangulo es: " + triangulo1.Tipo);
        }
    }
}
