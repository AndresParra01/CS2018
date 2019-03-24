using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsayoRepaso
{
    class Punto4
    {
        public delegate void Llamado();
        public static event Llamado EnConstruccion;
        public Punto4()
        {
            EnConstruccion();
        }
    }
}
