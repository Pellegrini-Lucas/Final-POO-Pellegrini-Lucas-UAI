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
        public FormGestionarProductos()
        {
            InitializeComponent();
        }
        private void CargarCmbRubros()
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
                    Producto productoSeleccionado = listaProductosMemoria.FirstOrDefault(p => p.Id == idProductoSeleccionado);
                    if (productoSeleccionado != null)
                    {
                        txt_NombreProducto.Text = productoSeleccionado.Nombre;
                        txt_DescripcionProducto.Text = productoSeleccionado.Descripcion;
                        txt_PrecioUnitarioProducto.Text = productoSeleccionado.PrecioUnitario.ToString();
                        cmb_RubroProducto.Text = productoSeleccionado.Rubro;
                        txt_StockProducto.Text = productoSeleccionado.Stock.ToString();
                    }
            }
        }
        private int GenerarIdProducto()
        {
            if (listaProductosMemoria.Count == 0)
                return 1;
            return listaProductosMemoria.Max(p => p.Id) + 1;
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
        private void txt_BuscarNombreProducto_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listaProductosEncontrados = new List<Producto>();
            if (txt_BuscarNombreProducto.TextLength > 0)
            {
                int id;
                if (int.TryParse(txt_BuscarNombreProducto.Text, out id))
                {
                    listaProductosEncontrados = listaProductosMemoriaFiltrada.FindAll(p => p.Id == int.Parse(txt_BuscarNombreProducto.Text) || p.Nombre.ToLower().Contains(txt_BuscarNombreProducto.Text.ToLower()));
                }
                else
                    listaProductosEncontrados = listaProductosMemoriaFiltrada.FindAll(p => p.Nombre.ToLower().Contains(txt_BuscarNombreProducto.Text.ToLower()));
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

            dgv_BancoProductos.Columns.Add("Id", "ID");
            dgv_BancoProductos.Columns["Id"].DataPropertyName = "Id";

            dgv_BancoProductos.Columns.Add("Nombre", "Nombre");
            dgv_BancoProductos.Columns["Nombre"].DataPropertyName = "Nombre";

            dgv_BancoProductos.Columns.Add("Descripcion", "Descripcion");
            dgv_BancoProductos.Columns["Descripcion"].DataPropertyName = "Descripcion";

            dgv_BancoProductos.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgv_BancoProductos.Columns["PrecioUnitario"].DataPropertyName = "PrecioUnitario";

            dgv_BancoProductos.Columns.Add("Rubro", "Rubro");
            dgv_BancoProductos.Columns["Rubro"].DataPropertyName = "Rubro";

            dgv_BancoProductos.Columns.Add("Stock", "Stock");
            dgv_BancoProductos.Columns["Stock"].DataPropertyName = "Stock";

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
        private void FormGestionarProductos_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarListaProductosMemoriaFiltrada();
            ActualizarDgvBancoProductos();
            CargarListaProductosMemoriaFiltrada();
            CargarCmbRubros();
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
            nuevoProducto.Id = GenerarIdProducto();
            nuevoProducto.Nombre = txt_NombreProducto.Text;
            nuevoProducto.Descripcion = txt_DescripcionProducto.Text;
            nuevoProducto.Rubro = cmb_RubroProducto.Text;
            try
            {
                nuevoProducto.PrecioUnitario = decimal.Parse(txt_PrecioUnitarioProducto.Text);
            }
            catch 
            {
                MessageBox.Show("El precio unitario ingresado no es un precio valido");
                return;
            }
            try
            {
                nuevoProducto.Stock = int.Parse(txt_StockProducto.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese una cantidad de stock valida");
                return;
            }
            listaProductosMemoria.Add(nuevoProducto);
            string jsonString = JsonSerializer.Serialize(listaProductosMemoria);
            File.WriteAllText("productos.json", jsonString);
            CargarListaProductosMemoriaFiltrada();
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
                int idProductoSeleccionado = (int)dgv_BancoProductos.SelectedRows[0].Cells["Id"].Value;
                Producto productoSeleccionado = listaProductosMemoria.FirstOrDefault(p => p.Id == idProductoSeleccionado);
                if (productoSeleccionado != null)
                {
                    productoSeleccionado.Nombre = txt_NombreProducto.Text;
                    productoSeleccionado.Descripcion = txt_DescripcionProducto.Text;
                    productoSeleccionado.Rubro = cmb_RubroProducto.Text;
                    try
                    {
                        productoSeleccionado.PrecioUnitario = decimal.Parse(txt_PrecioUnitarioProducto.Text);
                    }
                    catch
                    {
                        MessageBox.Show("El precio unitario ingresado no es un precio valido");
                        return;
                    }
                    try
                    {
                        productoSeleccionado.Stock = int.Parse(txt_StockProducto.Text);
                    }
                    catch
                    {
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
                int idProductoSeleccionado = (int)dgv_BancoProductos.SelectedRows[0].Cells["Id"].Value;
                Producto productoSeleccionado = listaProductosMemoria.FirstOrDefault(p => p.Id == idProductoSeleccionado);
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
    }
}




