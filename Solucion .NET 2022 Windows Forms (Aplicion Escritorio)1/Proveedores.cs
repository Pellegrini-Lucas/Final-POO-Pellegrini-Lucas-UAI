using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    internal class Proveedores
    {
        public int Id { get; set; }
        public string NombreProveedor { get; set; }
        public string ContactoProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
        public string DireccionProveedor { get; set; }
        public bool Activo { get; set; } = true;
    }
}

