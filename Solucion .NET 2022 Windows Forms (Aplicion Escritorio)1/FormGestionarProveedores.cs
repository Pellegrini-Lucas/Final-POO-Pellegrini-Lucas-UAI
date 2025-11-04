using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    public partial class FormGestionarProveedores : Form
    {
        List<Proveedores> listaProveedoresMemoria = new List<Proveedores>();
        List<Proveedores> listaProveedoresMemoriaFiltrada = new List<Proveedores>();
        public FormGestionarProveedores()
        {
            InitializeComponent();
        }
        private int GenerarIdProveedor()
        {
            if (listaProveedoresMemoria.Count == 0)
                return 1;
            return listaProveedoresMemoria.Max(p => p.IdProveedor) + 1;
        }
        private void LimpiarCampos()
        {
            txt_ContactoProveedor.Text = string.Empty;
            txt_DireccionProveedor.Text = string.Empty;
            txt_NombreProveedor.Text = string.Empty;
            txt_TelefonoProveedor.Text = string.Empty;
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
        private void ActualizarDgvBancoProveedores()
        {
            dgv_BancoProveedores.AutoGenerateColumns = false;
            dgv_BancoProveedores.Columns.Clear();
            dgv_BancoProveedores.ReadOnly = true;
            dgv_BancoProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_BancoProveedores.MultiSelect = false;

            dgv_BancoProveedores.Columns.Add("IdProveedor", "ID");
            dgv_BancoProveedores.Columns["IdProveedor"].DataPropertyName = "IdProveedor";

            dgv_BancoProveedores.Columns.Add("NombreProveedor", "Nombre");
            dgv_BancoProveedores.Columns["NombreProveedor"].DataPropertyName = "NombreProveedor";

            dgv_BancoProveedores.Columns.Add("ContactoProveedor", "Contacto");
            dgv_BancoProveedores.Columns["ContactoProveedor"].DataPropertyName = "ContactoProveedor";

            dgv_BancoProveedores.Columns.Add("TelefonoProveedor", "Telefono");
            dgv_BancoProveedores.Columns["TelefonoProveedor"].DataPropertyName = "TelefonoProveedor";

            dgv_BancoProveedores.Columns.Add("DireccionProveedor", "Direccion");
            dgv_BancoProveedores.Columns["DireccionProveedor"].DataPropertyName = "DireccionProveedor";

            dgv_BancoProveedores.DataSource = null;
            dgv_BancoProveedores.DataSource = listaProveedoresMemoriaFiltrada;
        }
        private void btn_AgregarProveedores_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ContactoProveedor.Text) || string.IsNullOrEmpty(txt_DireccionProveedor.Text) || string.IsNullOrEmpty(txt_NombreProveedor.Text))
            {
                //en algun momento estaria bueno poner un lbl arriba de cada textbox que se ilumine rojo cuando un txt este incompleto
                MessageBox.Show("todos los campos deben estar completos");
                return;
            }
            Proveedores nuevoProveedor = new Proveedores();
            nuevoProveedor.IdProveedor = GenerarIdProveedor();
            if (listaProveedoresMemoriaFiltrada.Exists(p => p.NombreProveedor == txt_NombreProveedor.Text.ToLower()))
            {
                MessageBox.Show("Ya existe un producto con este nombre");
                return;
            }
            nuevoProveedor.NombreProveedor = txt_NombreProveedor.Text.ToLower();
            nuevoProveedor.ContactoProveedor = txt_ContactoProveedor.Text;
            nuevoProveedor.DireccionProveedor = txt_DireccionProveedor.Text;
            bool valido = Int64.TryParse(txt_TelefonoProveedor.Text, out _);
            if (valido == false)
            {
                MessageBox.Show("Un numero de telefono solo debe tener caracteres numericos");
                return;
            }
            if (txt_TelefonoProveedor.TextLength < 10)
            {
                MessageBox.Show("El numero de telefono es demasiado corto");
                return;
            }
            else
            {
                //string format no formatea un string formatea un numero a string
                nuevoProveedor.TelefonoProveedor= String.Format("{0:(###) ###-####}", Convert.ToInt64(txt_TelefonoProveedor.Text));
            }
            listaProveedoresMemoria.Add(nuevoProveedor);
            string jsonString = JsonSerializer.Serialize (listaProveedoresMemoria);
            File.WriteAllText("Proveedores.json", jsonString);
            CargarListaProveedoresMemoriaFiltrada();
            ActualizarDgvBancoProveedores();
            LimpiarCampos();
        }
        private void btn_ModificarProveedores_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ContactoProveedor.Text) || string.IsNullOrEmpty(txt_DireccionProveedor.Text) || string.IsNullOrEmpty(txt_NombreProveedor.Text))
            {
                //en algun momento estaria bueno poner un lbl arriba de cada textbox que se ilumine rojo cuando un txt este incompleto
                MessageBox.Show("todos los campos deben estar completos");
                return;
            }
            int idSeleccionado = (int)dgv_BancoProveedores.SelectedRows[0].Cells["IdProveedor"].Value;
            Proveedores ProveedorSeleccionado = listaProveedoresMemoria.FirstOrDefault(p => p.IdProveedor == idSeleccionado);
            ProveedorSeleccionado.ContactoProveedor = txt_ContactoProveedor.Text;
            ProveedorSeleccionado.DireccionProveedor = txt_DireccionProveedor.Text;
            ProveedorSeleccionado.NombreProveedor = txt_NombreProveedor.Text.ToLower();
            bool valido = Int64.TryParse(txt_TelefonoProveedor.Text, out _);
            if (valido == false)
            {
                MessageBox.Show("Un numero de telefono solo debe tener caracteres numericos");
                return;
            }
            if (txt_TelefonoProveedor.TextLength < 10)
            {
                MessageBox.Show("El numero de telefono es demasiado corto");
                return;
            }
            else
            {
                //string format no formatea un string formatea un numero a string
                ProveedorSeleccionado.TelefonoProveedor = String.Format("{0:(###) ###-####}", Convert.ToInt64(txt_TelefonoProveedor.Text));
            }
            string JsonString = JsonSerializer.Serialize(listaProveedoresMemoria);
            File.WriteAllText("Proveedores.json",JsonString);
            CargarListaProveedoresMemoriaFiltrada();
            ActualizarDgvBancoProveedores();
        }
        private void btn_BajaProveedores_Click(object sender, EventArgs e)
        {
            if (dgv_BancoProveedores.SelectedRows !=null)
            { 
                int idSeleccionado = (int)dgv_BancoProveedores.SelectedRows[0].Cells["IdProveedor"].Value;
                Proveedores ProveedorSeleccionado = listaProveedoresMemoria.FirstOrDefault(p => p.IdProveedor == idSeleccionado);
                listaProveedoresMemoria.Remove(ProveedorSeleccionado);
                string JsonString = JsonSerializer.Serialize(listaProveedoresMemoria);
                File.WriteAllText("Proveedores.json", JsonString);
                CargarListaProveedoresMemoriaFiltrada();
                ActualizarDgvBancoProveedores();
                LimpiarCampos();
            }
        }
        private void FormGestionarProveedores_Load(object sender, EventArgs e)
        {
            CargarListaProveedoresMemoriaFiltrada();
            ActualizarDgvBancoProveedores();
        }
        private void txt_BuscarNombreProveedor_TextChanged(object sender, EventArgs e)
        {
            List<Proveedores> listaProveedoresEncontrados = new List<Proveedores>();
            if (txt_BuscarNombreProveedor.TextLength > 0)
            { 
                listaProveedoresEncontrados = listaProveedoresMemoriaFiltrada.FindAll(p => p.NombreProveedor.ToLower().Contains(txt_BuscarNombreProveedor.Text.ToLower()));
                dgv_BancoProveedores.DataSource = listaProveedoresEncontrados;
            }
            if (listaProveedoresEncontrados.Count == 0) dgv_BancoProveedores.DataSource = null;
            if (txt_BuscarNombreProveedor.TextLength == 0) ActualizarDgvBancoProveedores();
        }
    }
}
