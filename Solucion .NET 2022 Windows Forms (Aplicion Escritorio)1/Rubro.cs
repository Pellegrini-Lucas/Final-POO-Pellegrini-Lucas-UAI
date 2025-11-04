using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    internal class Rubro
    {
        public int IdRubro { get; set; }
        public string NombreRubro { get; set; }
        public string DescripcionRubro { get; set; }
        public int CantidadProductosAsignados { get; set; }
        public bool Activo { get; set; } = true;
    }
}
