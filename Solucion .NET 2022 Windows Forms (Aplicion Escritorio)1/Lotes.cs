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
        public string NombreProducto { get; set; }
        public string NombreProveedor { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public bool Activo { get; set; } = true;
        public int Cantidad { get; set; }
        public enum Movimiento
        {
            Ingreso,
            Egreso
        } 
        public string MotivoEgreso { get; set; } = null;
        public Movimiento TipoMovimiento { get; set; }
    }
    }
