using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    public partial class FormGestionarReportes : Form
    {
        public FormGestionarReportes()
        {
            InitializeComponent();
        }
        List<Producto> listaProductosMemoria = new List<Producto>();
        List<Producto> listaProductosMemoriaFiltrada = new List<Producto>();
        List<Proveedores> listaProveedoresMemoria = new List<Proveedores>();
        List<Proveedores> listaProveedoresMemoriaFiltrada = new List<Proveedores>();
        List<Lotes> listaLotesMemoria = new List<Lotes>();
        List<Lotes> listaLotesMemoriaFiltrada = new List<Lotes>();
        List<Rubro> listaRubrosMemoria = new List<Rubro>();
        List<Rubro> listaRubrosMemoriaFiltrada = new List<Rubro>();
        private void CargarListaRubrosMemoriaFiltrada()
        {
            if (!File.Exists("Rubros.json"))
            {
                File.Create("Rubros.json").Close();
            }
            string jsonString = File.ReadAllText("Rubros.json");
            if (string.IsNullOrWhiteSpace(jsonString))
                listaRubrosMemoria = new List<Rubro>();
            else
                listaRubrosMemoria = JsonSerializer.Deserialize<List<Rubro>>(jsonString);
            listaRubrosMemoriaFiltrada = listaRubrosMemoria.Where(p => p.Activo == true).ToList();
        }
        private void CargarListaLotesMemoriaFiltrada()
        {
            if (!File.Exists("Lotes.json"))
            {
                File.Create("Lotes.json").Close();
            }
            string jsonString = File.ReadAllText("Lotes.json");
            if (string.IsNullOrWhiteSpace(jsonString))
            {
                listaLotesMemoria = new List<Lotes>();
            }
            else
                listaLotesMemoria = JsonSerializer.Deserialize<List<Lotes>>(jsonString);
            listaLotesMemoriaFiltrada = listaLotesMemoria.Where(p => p.Activo == true).ToList();
        }
        private void CargarListaProductosMemoriaFiltrada()
        {
            if (!File.Exists("productos.json"))
            {
                File.Create("productos.json").Close();
            }
            string jsonString = File.ReadAllText("productos.json");
            if (string.IsNullOrWhiteSpace(jsonString))
                listaProductosMemoria = new List<Producto>();
            else
                listaProductosMemoria = JsonSerializer.Deserialize<List<Producto>>(jsonString);
            listaProductosMemoriaFiltrada = listaProductosMemoria.Where(p => p.Activo == true).ToList();
        }
        private void CargarListaProveedoresMemoriaFiltrada()
        {
            if (!File.Exists("Proveedores.json"))
            {
                File.Create("Proveedores.json").Close();
            }
            string JsonString = File.ReadAllText("Proveedores.json");
            if (string.IsNullOrWhiteSpace(JsonString))
            {
                listaProveedoresMemoria = new List<Proveedores>();
            }
            else
            {
                listaProveedoresMemoria = JsonSerializer.Deserialize<List<Proveedores>>(JsonString);
                listaProveedoresMemoriaFiltrada = listaProveedoresMemoria.Where(p => p.Activo == true).ToList();
            }
        }
        private void GenerarReporteStockActualPorProducto()
        {
            foreach (var producto in listaProductosMemoriaFiltrada)
            {
                List<Lotes> lotesIngresadosASumar = listaLotesMemoriaFiltrada.Where(p => p.NombreProducto == producto.NombreProducto && p.TipoMovimiento == Lotes.Movimiento.Ingreso).ToList();
                int stockIngresadoTotal = lotesIngresadosASumar.Sum(p => p.Cantidad);
                List<Lotes> lotesEgresadosASumar = listaLotesMemoriaFiltrada.Where(p => p.NombreProducto == producto.NombreProducto && p.TipoMovimiento == Lotes.Movimiento.Egreso).ToList();
                int stockEgresadoTotal = lotesEgresadosASumar.Sum(p => p.Cantidad);
                int stockDisponible = stockIngresadoTotal - stockEgresadoTotal;
                Label lbl_StockTotalProducto = new Label();
                lbl_StockTotalProducto.Text = $"Producto: {producto.NombreProducto} - Stock Disponible: {stockDisponible}";
                lbl_StockTotalProducto.AutoSize = true;
                flp_StockActualPorProducto.Controls.Add(lbl_StockTotalProducto);
            }
            
        }
        private void GenerarReporteStockActualPorRubro()
        {
            foreach (var rubro in listaRubrosMemoriaFiltrada)
            {
                List<Producto> productosDelRubro = listaProductosMemoriaFiltrada.Where(p => p.RubroProducto == rubro.NombreRubro).ToList();
                int stockTotalRubro = 0;
                foreach (var producto in productosDelRubro)
                {
                    List<Lotes> lotesIngresadosASumar = listaLotesMemoriaFiltrada.Where(p => p.NombreProducto == producto.NombreProducto && p.TipoMovimiento == Lotes.Movimiento.Ingreso).ToList();
                    int stockIngresadoTotal = lotesIngresadosASumar.Sum(p => p.Cantidad);
                    List<Lotes> lotesEgresadosASumar = listaLotesMemoriaFiltrada.Where(p => p.NombreProducto == producto.NombreProducto && p.TipoMovimiento == Lotes.Movimiento.Egreso).ToList();
                    int stockEgresadoTotal = lotesEgresadosASumar.Sum(p => p.Cantidad);
                    int stockDisponible = stockIngresadoTotal - stockEgresadoTotal;
                    stockTotalRubro += stockDisponible;
                }
                Label lbl_StockTotalRubro = new Label();
                lbl_StockTotalRubro.Text = $"Rubro: {rubro.NombreRubro} - Stock Disponible: {stockTotalRubro}";
                lbl_StockTotalRubro.AutoSize = true;
                flp_StockActualPorRubro.Controls.Add(lbl_StockTotalRubro);
            }
        }
        private void GenerarReporteIngresosPorProveedor()
        {
            foreach (var Proveedor in listaProveedoresMemoriaFiltrada)
            {
                List<Lotes> lotesPorProveedor = listaLotesMemoriaFiltrada.Where(p => p.NombreProveedor == Proveedor.NombreProveedor && p.TipoMovimiento == Lotes.Movimiento.Ingreso).ToList();
                int ingresosTotalesPorProveedor = lotesPorProveedor.Sum(p => p.Cantidad);
                Label lbl_IngresosTotalesPorProveedor = new Label();
                lbl_IngresosTotalesPorProveedor.Text = $"Proveedor: {Proveedor.NombreProveedor} - Ingresos Totales: {ingresosTotalesPorProveedor}";
                lbl_IngresosTotalesPorProveedor.AutoSize = true;
                flp_IngresosPorProveedor.Controls.Add(lbl_IngresosTotalesPorProveedor);
            }
        }
        private void GenerarReporteBajoStockProductos()
        {
            int umbralBajoStock = 25; 
            foreach (var producto in listaProductosMemoriaFiltrada)
            {
                List<Lotes> lotesIngresadosASumar = listaLotesMemoriaFiltrada.Where(p => p.NombreProducto == producto.NombreProducto && p.TipoMovimiento == Lotes.Movimiento.Ingreso).ToList();
                int stockIngresadoTotal = lotesIngresadosASumar.Sum(p => p.Cantidad);
                List<Lotes> lotesEgresadosASumar = listaLotesMemoriaFiltrada.Where(p => p.NombreProducto == producto.NombreProducto && p.TipoMovimiento == Lotes.Movimiento.Egreso).ToList();
                int stockEgresadoTotal = lotesEgresadosASumar.Sum(p => p.Cantidad);
                int stockDisponible = stockIngresadoTotal - stockEgresadoTotal;
                if (stockDisponible < umbralBajoStock)
                {
                    Label lbl_BajoStockProducto = new Label();
                    lbl_BajoStockProducto.Text = $"Producto: {producto.NombreProducto} - Stock Disponible: {stockDisponible}";
                    lbl_BajoStockProducto.AutoSize = true;
                    flp_BajoStockProductos.Controls.Add(lbl_BajoStockProducto);
                }
            }
        }
        private void FormGestionarReportes_Load(object sender, EventArgs e)
        {
            CargarListaLotesMemoriaFiltrada();
            CargarListaProductosMemoriaFiltrada();
            CargarListaProveedoresMemoriaFiltrada();
            CargarListaRubrosMemoriaFiltrada();
            GenerarReporteStockActualPorProducto();
            GenerarReporteStockActualPorRubro();
            GenerarReporteIngresosPorProveedor();
            GenerarReporteBajoStockProductos();
        }
    }
}
