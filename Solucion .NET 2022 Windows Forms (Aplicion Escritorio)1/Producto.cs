using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    internal class Producto
    {
        public int IdProducto { get; set; }
        public int IdRubro { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal PrecioUnitarioProducto { get; set; }
        public string RubroProducto { get; set; }
        public int StockProducto { get; set; }
        public bool Activo { get; set; } = true;
    }
}
