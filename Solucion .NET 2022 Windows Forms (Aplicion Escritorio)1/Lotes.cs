using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    internal class Lotes
    {
        public int IdLote { get; set; }
        public DateTime FechaIngreso {get; set;}
        public DateTime? FechaEgreso {get; set;}
        public DateTime FechaVencimimento { get; set; }
        public bool Activo { get; set; } = true;
        public int IdProducto { get; set; }
    }
}
