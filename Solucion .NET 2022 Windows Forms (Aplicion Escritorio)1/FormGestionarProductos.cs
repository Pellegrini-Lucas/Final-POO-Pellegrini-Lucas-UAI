using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Contracts;
using System.Drawing.Text;

namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{ 
    public partial class FormGestionarProductos : Form
    {
        List<Producto> listaProductosMemoria = new List<Producto>();
        List<Producto> listaProductosMemoriaFiltrada = new List<Producto>();
        List<Rubro> listaRubrosMemoria = new List<Rubro>();
        List<Rubro> listaRubrosMemoriaFiltrada = new List<Rubro>();
        List<Lotes> listaLotesMemoria = new List<Lotes>();
        public FormGestionarProductos()
        {
            InitializeComponent();
        }
        private void CargarCmbRubros()
        {
            CargarListaRubrosMemoriaFiltrada();
            foreach (Rubro rubro in listaRubrosMemoriaFiltrada)
            {
                cmb_RubroProducto.Items.Add(rubro.NombreRubro);
            }
        }
        private void dgv_BancoProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_BancoProductos.SelectedRows.Count > 0)
            {
                    if (dgv_BancoProductos.SelectedRows[0].Cells[0].Value == null) return;
                    int idProductoSeleccionado = (int)dgv_BancoProductos.SelectedRows[0].Cells[0].Value;
                    Producto productoSeleccionado = listaProductosMemoria.FirstOrDefault(p => p.IdProducto == idProductoSeleccionado);
                    if (productoSeleccionado != null)
                    {
                        txt_NombreProducto.Text = productoSeleccionado.NombreProducto;
                        txt_DescripcionProducto.Text = productoSeleccionado.DescripcionProducto;
                        txt_PrecioUnitarioProducto.Text = productoSeleccionado.PrecioUnitarioProducto.ToString();
                        cmb_RubroProducto.Text = productoSeleccionado.RubroProducto;
                        txt_StockProducto.Text = productoSeleccionado.StockProducto.ToString();
                    }
            }
        }
        private int GenerarIdProducto()
        {
            if (listaProductosMemoria.Count == 0)
                return 1;
            return listaProductosMemoria.Max(p => p.IdProducto) + 1;
        }
        private int GenerarIdLote()
        {
            if (listaLotesMemoria.Count == 0)
                return 1;
            return listaLotesMemoria.Max(p => p.IdLote) + 1;
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
        private void CargarListaLotesMemoria()
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
        }
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
        private void txt_BuscarNombreProducto_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listaProductosEncontrados = new List<Producto>();
            if (txt_BuscarNombreProducto.TextLength > 0)
            {
                int id;
                if (int.TryParse(txt_BuscarNombreProducto.Text, out id))
                {
                    //aca tambien busco en nombreproducto por si el nombre tiene numeros
                    listaProductosEncontrados = listaProductosMemoriaFiltrada.FindAll(p => p.IdProducto == int.Parse(txt_BuscarNombreProducto.Text) || p.NombreProducto.ToLower().Contains(txt_BuscarNombreProducto.Text.ToLower()));
                }
                else
                    listaProductosEncontrados = listaProductosMemoriaFiltrada.FindAll(p => p.NombreProducto.ToLower().Contains(txt_BuscarNombreProducto.Text.ToLower()));
                if (listaProductosEncontrados.Count == 0) dgv_BancoProductos.DataSource = null;
                else dgv_BancoProductos.DataSource = listaProductosEncontrados;
            } 
            if (txt_BuscarNombreProducto.TextLength == 0)
            {
                ActualizarDgvBancoProductos();
            }
        }
        private void ActualizarDgvBancoProductos ()
        {

            dgv_BancoProductos.AutoGenerateColumns = false;
            dgv_BancoProductos.Columns.Clear();
            dgv_BancoProductos.ReadOnly = true;
            dgv_BancoProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_BancoProductos.MultiSelect = false;

            dgv_BancoProductos.Columns.Add("IdProducto", "ID");
            dgv_BancoProductos.Columns["IdProducto"].DataPropertyName = "IdProducto";

            dgv_BancoProductos.Columns.Add("NombreProducto", "Nombre");
            dgv_BancoProductos.Columns["NombreProducto"].DataPropertyName = "NombreProducto";

            dgv_BancoProductos.Columns.Add("DescripcionProducto", "Descripcion");
            dgv_BancoProductos.Columns["DescripcionProducto"].DataPropertyName = "DescripcionProducto";

            dgv_BancoProductos.Columns.Add("PrecioUnitarioProducto", "Precio Unitario");
            dgv_BancoProductos.Columns["PrecioUnitarioProducto"].DataPropertyName = "PrecioUnitarioProducto";

            dgv_BancoProductos.Columns.Add("RubroProducto", "Rubro");
            dgv_BancoProductos.Columns["RubroProducto"].DataPropertyName = "RubroProducto";

            dgv_BancoProductos.Columns.Add("StockProducto", "Stock");
            dgv_BancoProductos.Columns["StockProducto"].DataPropertyName = "StockProducto";

            dgv_BancoProductos.DataSource = null;
            dgv_BancoProductos.DataSource = listaProductosMemoriaFiltrada;
        }
        private void LimpiarCampos()
        {
            txt_NombreProducto.Text = "";
            txt_DescripcionProducto.Text = "";
            txt_PrecioUnitarioProducto.Text = "";
            cmb_RubroProducto.Text = "";
            txt_StockProducto.Text = "";
        }
        private void GestorControlesVencimiento()
        {
            if (rbt_Perecedero.Checked)
            {
                lbl_Vencimiento.Enabled = true;
                dtp_VencimientoStockIngresanteEgresante.Enabled = true;
            }
            else
            {
                lbl_Vencimiento.Enabled = false;
                dtp_VencimientoStockIngresanteEgresante.Enabled = false;
            }
        }
        private void FormGestionarProductos_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarListaProductosMemoriaFiltrada();
            ActualizarDgvBancoProductos();
            CargarListaProductosMemoriaFiltrada();
            CargarCmbRubros();
            GestorControlesVencimiento();
        }
        private void btn_AgregarProductos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_NombreProducto.Text) || string.IsNullOrEmpty(txt_PrecioUnitarioProducto.Text) || string.IsNullOrEmpty(txt_StockProducto.Text) || string.IsNullOrEmpty(txt_DescripcionProducto.Text) || cmb_RubroProducto.SelectedItem == null)
            {
                //en algun momento estaria bueno poner un lbl arriba de cada textbox que se ilumine rojo cuando un txt este incompleto   
                MessageBox.Show("todos los campos deben estar completos");
                return;
            }
            Producto nuevoProducto = new Producto();
            nuevoProducto.IdProducto = GenerarIdProducto();
            if (listaProductosMemoriaFiltrada.Exists(p => p.NombreProducto == txt_NombreProducto.Text.ToLower()))
            {
                MessageBox.Show("Ya existe un producto con este nombre");
                return;
            }
            nuevoProducto.NombreProducto = txt_NombreProducto.Text.ToLower();
            nuevoProducto.DescripcionProducto = txt_DescripcionProducto.Text;
            nuevoProducto.RubroProducto = cmb_RubroProducto.Text;
            try
            {
                if (decimal.Parse(txt_PrecioUnitarioProducto.Text) < 0 || decimal.Parse(txt_PrecioUnitarioProducto.Text) == 0)
                {
                    MessageBox.Show("El precio unitario no puede ser un numero negativo o cero");
                    return;
                }
                nuevoProducto.PrecioUnitarioProducto = decimal.Parse(txt_PrecioUnitarioProducto.Text);
            }
            catch 
            {
                MessageBox.Show("El precio unitario ingresado no es un precio valido");
                return;
            }
            try
            {
                if (int.Parse(txt_StockProducto.Text) < 0 || int.Parse(txt_StockProducto.Text) == 0)
                {
                    MessageBox.Show("El stock no puede ser un numero negativo o cero");
                    return;
                }
                nuevoProducto.StockProducto = int.Parse(txt_StockProducto.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad de stock valida");
                return;
            }
            Rubro rubroSeleccionado = listaRubrosMemoriaFiltrada.FirstOrDefault(p => p.NombreRubro == cmb_RubroProducto.Text);
            nuevoProducto.IdRubro = rubroSeleccionado.IdRubro;
            rubroSeleccionado.CantidadProductosAsignados += 1;

            //

            Lotes nuevoLote = new Lotes();
            nuevoLote.NombreProducto = nuevoProducto.NombreProducto;
            nuevoLote.IdLote = GenerarIdLote();
            nuevoLote.FechaMovimiento = DateTime.Now.Date;
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
            nuevoLote.TipoMovimiento = Lotes.Movimiento.Ingreso;
            nuevoLote.NombreProducto = nuevoProducto.NombreProducto;
            nuevoLote.NombreProveedor = string.Empty;
            nuevoLote.Cantidad = nuevoProducto.StockProducto;

            listaProductosMemoria.Add(nuevoProducto);
            string jsonString = JsonSerializer.Serialize(listaProductosMemoria);
            File.WriteAllText("productos.json", jsonString);
            CargarListaProductosMemoriaFiltrada();

            listaLotesMemoria.Add(nuevoLote);
            jsonString = JsonSerializer.Serialize(listaLotesMemoria);
            File.WriteAllText("lotes.json", jsonString);
            CargarListaLotesMemoria();
            ActualizarDgvBancoProductos();
            LimpiarCampos();
        }
        private void btn_ModificarProductos_Click(object sender, EventArgs e)
        {
            if (dgv_BancoProductos.SelectedRows!=null)
            {
                if (string.IsNullOrEmpty(txt_NombreProducto.Text) || string.IsNullOrEmpty(txt_PrecioUnitarioProducto.Text) || string.IsNullOrEmpty(txt_StockProducto.Text) || string.IsNullOrEmpty(txt_DescripcionProducto.Text) || cmb_RubroProducto.SelectedItem == null)
                {
                    //en algun momento estaria bueno poner un lbl arriba de cada textbox que se ilumine rojo cuando un txt este incompleto
                    MessageBox.Show("todos los campos deben estar completos");
                    return;
                }
                int idProductoSeleccionado = (int)dgv_BancoProductos.SelectedRows[0].Cells["IdProducto"].Value;
                Producto productoSeleccionado = listaProductosMemoria.FirstOrDefault(p => p.IdProducto == idProductoSeleccionado);
                if (productoSeleccionado != null)
                {
                    if (listaProductosMemoria.Exists(p => p.NombreProducto == txt_NombreProducto.Text.ToLower()))
                    {
                        MessageBox.Show("Ya existe un producto con este nombre");
                        return;
                    }
                    productoSeleccionado.NombreProducto = txt_NombreProducto.Text.ToLower();
                    productoSeleccionado.DescripcionProducto = txt_DescripcionProducto.Text;
                    productoSeleccionado.RubroProducto = cmb_RubroProducto.Text;
                    try
                    {
                        if (decimal.Parse(txt_PrecioUnitarioProducto.Text) < 0 || decimal.Parse(txt_PrecioUnitarioProducto.Text) == 0)
                        {
                            MessageBox.Show("El precio unitario no puede ser un numero negativo o cero");
                            return;
                        }
                            productoSeleccionado.PrecioUnitarioProducto = decimal.Parse(txt_PrecioUnitarioProducto.Text);
                    }
                    catch
                    {
                        MessageBox.Show("El precio unitario ingresado no es un precio valido");
                        return;
                    }
                    try
                    {
                        productoSeleccionado.StockProducto = int.Parse(txt_StockProducto.Text);
                    }
                    catch
                    {
                        if (int.Parse(txt_StockProducto.Text) < 0 || int.Parse(txt_StockProducto.Text) == 0)
                        {
                            MessageBox.Show("El stock no puede ser un numero negativo o cero");
                            return;
                        }
                        MessageBox.Show("Ingrese una cantidad de stock valida");
                        return;
                    }
                    string jsonString = JsonSerializer.Serialize(listaProductosMemoria);
                    File.WriteAllText("productos.json", jsonString);
                    CargarListaProductosMemoriaFiltrada();
                    ActualizarDgvBancoProductos();
                }
            }
        }
        private void btn_BajaProductos_Click(object sender, EventArgs e)
        {
            if (dgv_BancoProductos.SelectedRows != null)
            {
                int idProductoSeleccionado = (int)dgv_BancoProductos.SelectedRows[0].Cells["IdProducto"].Value;
                Producto productoSeleccionado = listaProductosMemoria.FirstOrDefault(p => p.IdProducto == idProductoSeleccionado);
                if (productoSeleccionado != null)
                {
                    productoSeleccionado.Activo = false;
                    string jsonString = JsonSerializer.Serialize(listaProductosMemoria);
                    File.WriteAllText("productos.json", jsonString);
                    CargarListaProductosMemoriaFiltrada();
                    ActualizarDgvBancoProductos();
                }
            }
        }

        private void btn_Pruebas_Click(object sender, EventArgs e)
        {
            CargarListaLotesMemoria();
            MessageBox.Show($"{DateTime.Today.Date}");
        }

        private void rbt_Perecedero_CheckedChanged(object sender, EventArgs e)
        {
            GestorControlesVencimiento();
        }
    }
}