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
    public partial class FormGestionarStock : Form
    {
        List<Producto> listaProductosMemoria = new List<Producto>();
        List<Producto> listaProductosMemoriaFiltrada = new List<Producto>();
        List<Proveedores> listaProveedoresMemoria = new List<Proveedores>();
        List<Proveedores> listaProveedoresMemoriaFiltrada = new List<Proveedores>();
        List<Lotes> listaLotesMemoria = new List<Lotes>();
        List<Lotes> listaLotesMemoriaFiltrada = new List<Lotes>();
        public FormGestionarStock()
        {
            InitializeComponent();
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
        private int GenerarIdLote()
        {
            if (listaLotesMemoria.Count == 0)
                return 1;
            return listaLotesMemoria.Max(p => p.IdLote) + 1;
        }
        private void CargarCmbProductos()
        {
            CargarListaProductosMemoriaFiltrada();
            foreach (Producto producto in listaProductosMemoriaFiltrada)
            {
                cmb_ProductoStockIngresanteEgresante.Items.Add(producto.NombreProducto);
            }
        }
        private void CargarCmbProveedores()
        {
            CargarListaProveedoresMemoriaFiltrada();
            foreach (Proveedores proveedor in listaProveedoresMemoriaFiltrada)
            {
                cmb_ProveedorStockIngresanteEgresante.Items.Add(proveedor.NombreProveedor);
            }
        }
        private void cargarCmbFiltros()
        {
            cmb_OpcionesDeFiltrado.Items.Add("Todos");
            cmb_OpcionesDeFiltrado.Items.Add("Movimientos de Productos");
            cmb_OpcionesDeFiltrado.Items.Add("Tipos de movimientos");
            cmb_OpcionesDeFiltrado.Items.Add("Movimientos por rango de Fecha");
            cmb_OpcionesDeFiltrado.SelectedIndex = 0;
        }
        private void ActualizarDgvBancoProductos()
        {

            dgv_IngresosEgresos.AutoGenerateColumns = false;
            dgv_IngresosEgresos.Columns.Clear();
            dgv_IngresosEgresos.ReadOnly = true;
            dgv_IngresosEgresos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_IngresosEgresos.MultiSelect = false;

            dgv_IngresosEgresos.Columns.Add("IdLote", "ID");
            dgv_IngresosEgresos.Columns["IdLote"].DataPropertyName = "IdLote";

            dgv_IngresosEgresos.Columns.Add("NombreProducto", "Producto");
            dgv_IngresosEgresos.Columns["NombreProducto"].DataPropertyName = "NombreProducto";

            dgv_IngresosEgresos.Columns.Add("StockManipulado", "Stock");
            dgv_IngresosEgresos.Columns["StockManipulado"].DataPropertyName = "Cantidad";

            dgv_IngresosEgresos.Columns.Add("Movimiento", "Movimiento");
            dgv_IngresosEgresos.Columns["Movimiento"].DataPropertyName = "TipoMovimiento";

            dgv_IngresosEgresos.Columns.Add("MotivoEgreso", "Motivo Egreso");
            dgv_IngresosEgresos.Columns["MotivoEgreso"].DataPropertyName = "MotivoEgreso";

            dgv_IngresosEgresos.Columns.Add("Proveedor", "Proveedor");
            dgv_IngresosEgresos.Columns["Proveedor"].DataPropertyName = "NombreProveedor";

            dgv_IngresosEgresos.Columns.Add("FechaMovimiento", "Fecha");
            dgv_IngresosEgresos.Columns["FechaMovimiento"].DataPropertyName = "FechaMovimiento";

            dgv_IngresosEgresos.Columns.Add("FechaVencimiento", "Vencimiento");
            dgv_IngresosEgresos.Columns["FechaVencimiento"].DataPropertyName = "FechaVencimiento";

            dgv_IngresosEgresos.DataSource = null;
            dgv_IngresosEgresos.DataSource = listaLotesMemoriaFiltrada;
        }
        private void GestorControlesVencimiento()
        {
            if (rbt_Perecedero.Checked)
            {
                label4.Enabled = true;
                dtp_VencimientoStockIngresanteEgresante.Enabled = true;
            }
            else
            {
                label4.Enabled = false;
                dtp_VencimientoStockIngresanteEgresante.Enabled = false;
            }
        }

        private void FormGestionarStock_Load(object sender, EventArgs e)
        {
            CargarListaLotesMemoriaFiltrada();
            CargarListaProductosMemoriaFiltrada();
            CargarListaProveedoresMemoriaFiltrada();
            CargarCmbProductos();
            CargarCmbProveedores();
            cargarCmbFiltros();
            ActualizarDgvBancoProductos();
            GestorControlesVencimiento();
        }
        private void rbt_Perecedero_CheckedChanged(object sender, EventArgs e)
        {
            GestorControlesVencimiento();
        }
        private void btn_IngresarStock_Click(object sender, EventArgs e)
        {
            Lotes nuevoLote = new Lotes();
            nuevoLote.IdLote = GenerarIdLote();
            if (cmb_ProductoStockIngresanteEgresante.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto para realizar el ingreso de stock");
                return;
            }
            nuevoLote.NombreProducto = cmb_ProductoStockIngresanteEgresante.SelectedItem.ToString();
            if (cmb_ProveedorStockIngresanteEgresante.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un proveedor para realizar el ingreso de stock");
                return;
            }
            nuevoLote.NombreProveedor = cmb_ProveedorStockIngresanteEgresante.SelectedItem.ToString();
            bool valido = int.TryParse(txt_CantidadStockIngresanteEgresante.Text, out int cantidadStockIngresante);
            if (valido == false || cantidadStockIngresante <= 0)
            {
                MessageBox.Show("La cantidad de stock ingresante debe ser un numero entero positivo");
                return;
            }
            nuevoLote.Cantidad = cantidadStockIngresante;
            nuevoLote.FechaMovimiento = dtp_FechaIngresoEgresoStock.Value;
            nuevoLote.TipoMovimiento = Lotes.Movimiento.Ingreso;
            if (rbt_Perecedero.Checked)
            {
                int revisionVencimiento = DateTime.Compare(dtp_VencimientoStockIngresanteEgresante.Value.Date, DateTime.Now.Date);
                if (revisionVencimiento < 0 || revisionVencimiento == 0)
                {
                    MessageBox.Show("La fecha de vencimiento no puede ser la fecha actual ni una anterior");
                    return;
                }
                nuevoLote.FechaVencimiento = dtp_VencimientoStockIngresanteEgresante.Value;
            }
            else
            {
                nuevoLote.FechaVencimiento = null;
            }
            listaLotesMemoria.Add(nuevoLote);
            string jsonString = JsonSerializer.Serialize(listaLotesMemoria);
            File.WriteAllText("Lotes.json", jsonString);
            CargarListaLotesMemoriaFiltrada();
            ActualizarDgvBancoProductos();
        }
        private void btn_EgresoStock_Click(object sender, EventArgs e)
        {
            Lotes nuevoLote = new Lotes(); 
            nuevoLote.IdLote = GenerarIdLote();
            if (cmb_ProductoStockIngresanteEgresante.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto para realizar el ingreso de stock");
                return;
            }
            nuevoLote.NombreProducto = cmb_ProductoStockIngresanteEgresante.SelectedItem.ToString();
            nuevoLote.NombreProveedor = null;
            bool valido = int.TryParse(txt_CantidadStockIngresanteEgresante.Text, out int cantidadStockEgresante);
            if (valido == false || cantidadStockEgresante <= 0)
            {
                MessageBox.Show("La cantidad de stock ingresante debe ser un numero entero positivo");
                return;
            }
            List<Lotes> lotesIngresadosASumar = listaLotesMemoriaFiltrada.Where(p => p.NombreProducto == nuevoLote.NombreProducto && p.TipoMovimiento == Lotes.Movimiento.Ingreso).ToList();
            int stockIngresadoTotal = lotesIngresadosASumar.Sum(p => p.Cantidad);
            List<Lotes> lotesEgresadosASumar = listaLotesMemoriaFiltrada.Where(p => p.NombreProducto == nuevoLote.NombreProducto && p.TipoMovimiento == Lotes.Movimiento.Egreso).ToList();
            int stockEgresadoTotal = lotesEgresadosASumar.Sum(p => p.Cantidad);
            int stockDisponible = stockIngresadoTotal - stockEgresadoTotal;
            if (cantidadStockEgresante > stockDisponible)
            {
                MessageBox.Show("No hay suficiente stock disponible para realizar este egreso");
                return;
            }
            else
            {
                nuevoLote.Cantidad = cantidadStockEgresante;
            }
            nuevoLote.FechaMovimiento = dtp_FechaIngresoEgresoStock.Value;
            nuevoLote.FechaVencimiento = null;
            nuevoLote.TipoMovimiento = Lotes.Movimiento.Egreso;
            using (CustomDialog motivoEgreso = new CustomDialog())
            {
                motivoEgreso.ShowDialog();
                switch (motivoEgreso.MotivoSeleccionado)
                {
                    case MotivoEgreso.Venta:
                        nuevoLote.MotivoEgreso = "Venta";
                        break;
                    case MotivoEgreso.Merma:
                        nuevoLote.MotivoEgreso = "Merma";
                        break;
                    case MotivoEgreso.NoSeleccionado:
                        MessageBox.Show("No se selecciono un motivo de egreso, la operacion se cancelara");
                        return;
                }
            }
            listaLotesMemoria.Add(nuevoLote);
            string jsonString = JsonSerializer.Serialize(listaLotesMemoria);
            File.WriteAllText("Lotes.json", jsonString);
            CargarListaLotesMemoriaFiltrada();
            ActualizarDgvBancoProductos();
        }
        private void cmb_OpcionesDeFiltrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_OpcionesDeFiltrado.SelectedIndex == 0)
            {
                lbl_Filtro.Visible = false;
                cmb_FiltroMovProductos.Visible = false;
                cmb_FiltroMovTipo.Visible = false;
                dtp_FiltroFechaDesde.Visible = false;
                dtp_FiltroFechaHasta.Visible = false;
                ActualizarDgvBancoProductos();
            }
            if (cmb_OpcionesDeFiltrado.SelectedIndex == 1)
            {
                CargarListaLotesMemoriaFiltrada();
                lbl_Filtro.Text = "Seleccione el Producto:";
                lbl_Filtro.Visible = true;
                cmb_FiltroMovProductos.Visible = true;
                cmb_FiltroMovTipo.Visible = false;
                dtp_FiltroFechaDesde.Visible = false;
                dtp_FiltroFechaHasta.Visible = false;
                foreach (Lotes Lotes in listaLotesMemoriaFiltrada)
                {
                    if (!cmb_FiltroMovProductos.Items.Contains(Lotes.NombreProducto))
                    {
                        cmb_FiltroMovProductos.Items.Add(Lotes.NombreProducto);
                    }
                }
            }
            if (cmb_OpcionesDeFiltrado.SelectedIndex == 2)
            {
                lbl_Filtro.Text = "Seleccione el Tipo de Movimiento:";
                lbl_Filtro.Visible = true;
                cmb_FiltroMovProductos.Visible = false;
                cmb_FiltroMovTipo.Visible = true;
                dtp_FiltroFechaDesde.Visible = false;
                dtp_FiltroFechaHasta.Visible = false;
                cmb_FiltroMovTipo.Items.Add(Lotes.Movimiento.Ingreso.ToString());
                cmb_FiltroMovTipo.Items.Add(Lotes.Movimiento.Egreso.ToString());
            }
            if (cmb_OpcionesDeFiltrado.SelectedIndex == 3)
            {
                lbl_Filtro.Text = "Seleccione el Rango de Fechas Desde:";
                lbl_Filtro.Visible = true;
                lbl_FechaHasta.Visible = true;
                lbl_FechaHasta.Text = "Hasta:";
                cmb_FiltroMovProductos.Visible = false;
                cmb_FiltroMovTipo.Visible = false;
                dtp_FiltroFechaDesde.Visible = true;
                dtp_FiltroFechaHasta.Visible = true;
            }
        }
        private void cmb_FiltroMovProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Lotes> listaFiltradaPorProducto = listaLotesMemoriaFiltrada.Where(p => p.NombreProducto == cmb_FiltroMovProductos.SelectedItem.ToString()).ToList();
            dgv_IngresosEgresos.DataSource = null;
            dgv_IngresosEgresos.DataSource = listaFiltradaPorProducto;
        }
        private void cmb_FiltroMovTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Lotes> listaFiltradaPorTipo = listaLotesMemoriaFiltrada.Where(p => p.TipoMovimiento.ToString() == cmb_FiltroMovTipo.SelectedItem.ToString()).ToList();
            dgv_IngresosEgresos.DataSource = null;
            dgv_IngresosEgresos.DataSource = listaFiltradaPorTipo;
        }
        private void dtp_FiltroFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            int revisionVencimiento = DateTime.Compare(dtp_FiltroFechaDesde.Value.Date, dtp_FiltroFechaHasta.Value.Date);
            if (revisionVencimiento > 0 || revisionVencimiento == 0)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor ni igual que la fecha de finalizacion de filtrado");
                return;
            }
            DateTime fechaDesde = dtp_FiltroFechaDesde.Value.Date;
            DateTime fechaHasta = dtp_FiltroFechaHasta.Value.Date;
            List<Lotes> listaFiltradaPorFecha = listaLotesMemoriaFiltrada.Where(p => p.FechaMovimiento.Date >= fechaDesde && p.FechaMovimiento.Date <= fechaHasta).ToList();
            dgv_IngresosEgresos.DataSource = null;
            dgv_IngresosEgresos.DataSource = listaFiltradaPorFecha;
        }
        private void dtp_FiltroFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            int revisionVencimiento = DateTime.Compare(dtp_FiltroFechaDesde.Value.Date, dtp_FiltroFechaHasta.Value.Date);
            if (revisionVencimiento > 0 || revisionVencimiento == 0)
            {
                MessageBox.Show("La fecha de finalizacion no puede ser menor ni igual que la fecha de inicio de filtrado");
                return;
            }
            DateTime fechaDesde = dtp_FiltroFechaDesde.Value.Date;
            DateTime fechaHasta = dtp_FiltroFechaHasta.Value.Date;
            List<Lotes> listaFiltradaPorFecha = listaLotesMemoriaFiltrada.Where(p => p.FechaMovimiento.Date >= fechaDesde && p.FechaMovimiento.Date <= fechaHasta).ToList();
            dgv_IngresosEgresos.DataSource = null;
            dgv_IngresosEgresos.DataSource = listaFiltradaPorFecha;
        }
    }
}
