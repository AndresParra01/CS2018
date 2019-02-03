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
            double saludinicial, armadurainicial, dañoinicial, saludnivel, armaduranivel, dañonivel, salud, daño, armadura;

            Console.WriteLine("Ingrese su nivel de campeon");
            int nivel = int.Parse(Console.ReadLine());

            saludinicial = 576.54;
            saludnivel = 54.8;
            armadurainicial = 56.9;
            armaduranivel = 9.7;
            dañoinicial = 64;
            dañonivel = 13;

            salud = saludinicial + (saludnivel * nivel);
            armadura = armadurainicial + (armaduranivel * nivel);
            daño = dañoinicial + (dañonivel * nivel);

            Console.WriteLine("Su salud es" + " " + salud + "/" + "Su armadura es" + " " + armadura + "/" + "Su daño es" + " " + daño);
        }
    }
}
