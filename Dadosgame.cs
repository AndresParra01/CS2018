using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1, dado2, total, dobles, seis, contador;

            dado1 = 0;
            dado2 = 0;
            total = 0;
            dobles = 0;
            seis = 0;
            contador = 0;

            string continuar = "1";
            Console.WriteLine("Si desea jugar ahora, presione 1, de lo contrario presione 0");

            while(continuar == "1" && (dado1 != 1 || dado2 != 2))
            {
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);

                Console.WriteLine("Su dado numero 1 es" + " " + dado1 + " " + "Su dado numero 2 es" + " " + dado2);

                if(dado1 == 1 && dado2 == 1)
                {
                    total = 0;
                    Console.WriteLine("Has sido eliminado");
                }
                else
                {
                    total += dado1 + dado2;
                    Console.WriteLine("Total:" + total);

                    if(dado1 == dado2) dobles += 1;
                    else dobles = 0;
                    if ((dado1 + dado2) > 6) seis += 1; 

                    if(total >= 100 || dobles >= 3)
                    {
                        Console.WriteLine("Felicitaciones crack");
                        continuar = "0";
                    }
                    else
                    {
                        Console.WriteLine("¿Desea continuar? 1/0");
                        continuar = Console.ReadLine();
                    }
                }
                contador += 1;
            }
            Console.WriteLine("Su total fue" + " " + total);
            double porcentaje = 100 * (((double)seis) / contador);
            Console.WriteLine("El" + porcentaje + "% de turnos obtuvo mas de 6");

            Console.WriteLine("Nos vemos luego prro");
        }
    }
}
