using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    public partial class FormGestionarRubro : Form
    {
        public FormGestionarRubro()
        {
            InitializeComponent();
        }
        List<Producto> listaProductosMemoria = new List<Producto>();
        List<Producto> listaProductosMemoriaFiltrada = new List<Producto>();
        List <Rubro> listaRubrosMemoria = new List <Rubro>();
        List<Rubro> listaRubrosMemoriaFiltrada = new List<Rubro>();
        private void LimpiarCampos()
        {
            txt_NombreRubro.Text = "";
            txt_DescripcionRubro.Text = "";
        }
        private int GenerarIdProducto()
        {
            if (listaRubrosMemoria.Count == 0)
                return 1;
            return listaRubrosMemoria.Max(p => p.IdRubro) + 1;
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
        private void AsignarProductosRubro()
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
            foreach (Rubro rubro in listaRubrosMemoriaFiltrada)
            {
                List<Producto> productosAAsignar = listaProductosMemoriaFiltrada.FindAll(p => p.RubroProducto == rubro.NombreRubro);
                rubro.CantidadProductosAsignados = productosAAsignar.Count;
            }
        }
        private void ActualizarDgv()
        {
            dgv_BancoRubros.AutoGenerateColumns = false;
            dgv_BancoRubros.MultiSelect = false;
            dgv_BancoRubros.ReadOnly = true;
            dgv_BancoRubros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_BancoRubros.Columns.Clear();

            dgv_BancoRubros.Columns.Add("IdRubro", "ID");
            dgv_BancoRubros.Columns["IdRubro"].DataPropertyName = "IdRubro";

            dgv_BancoRubros.Columns.Add("NombreRubro","Rubro");
            dgv_BancoRubros.Columns["NombreRubro"].DataPropertyName = "NombreRubro";

            dgv_BancoRubros.Columns.Add("DescripcionRubro", "Descripcion");
            dgv_BancoRubros.Columns["DescripcionRubro"].DataPropertyName = "DescripcionRubro";

            dgv_BancoRubros.Columns.Add("CantidadProductosAsignados", "Productos Asignados");
            dgv_BancoRubros.Columns["CantidadProductosAsignados"].DataPropertyName = "CantidadProductosAsignados";

            dgv_BancoRubros.DataSource = null;
            dgv_BancoRubros.DataSource = listaRubrosMemoriaFiltrada;
        }
        private void btn_AgregarRubro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_DescripcionRubro.Text)||string.IsNullOrEmpty(txt_NombreRubro.Text))
            {
                MessageBox.Show("todos los campos deben estar completos");
                return;
            }
            Rubro nuevoRubro = new Rubro();
            nuevoRubro.IdRubro = GenerarIdProducto();
            if (listaRubrosMemoriaFiltrada.Exists(p => p.NombreRubro == nuevoRubro.NombreRubro))
            {
                MessageBox.Show($"el Rubro {nuevoRubro.NombreRubro} ya existe");
                return;
            }
            nuevoRubro.NombreRubro = txt_NombreRubro.Text.ToLower();
            nuevoRubro.DescripcionRubro = txt_DescripcionRubro.Text;
            nuevoRubro.CantidadProductosAsignados = 0;
            listaRubrosMemoria.Add(nuevoRubro);
            string JsonString = JsonSerializer.Serialize(listaRubrosMemoria);
            File.WriteAllText("Rubros.json", JsonString);
            CargarListaRubrosMemoriaFiltrada();
            ActualizarDgv();
            LimpiarCampos();
        }
        private void btn_ModificarRubro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_DescripcionRubro.Text) || string.IsNullOrEmpty(txt_NombreRubro.Text))
            {

                MessageBox.Show("todos los campos deben estar completos");
                return;
            }
            if (dgv_BancoRubros.SelectedRows != null)
            {
                int idRubroSeleccionado = (int)dgv_BancoRubros.SelectedRows[0].Cells["IdRubro"].Value;
                Rubro rubro = listaRubrosMemoria.FirstOrDefault(p => p.IdRubro == idRubroSeleccionado);
                rubro.DescripcionRubro = txt_DescripcionRubro.Text;
                if (!listaRubrosMemoriaFiltrada.Exists(p => p.NombreRubro == txt_NombreRubro.Text))
                {
                    rubro.NombreRubro = txt_NombreRubro.Text.ToLower();
                    string jsonString = JsonSerializer.Serialize(listaRubrosMemoria);
                    File.WriteAllText("Rubros.json", jsonString);
                    CargarListaRubrosMemoriaFiltrada();
                    ActualizarDgv();
                }
                else MessageBox.Show("El nombre a modificar no puede coincidir con uno ya existente");
                {
                    return;
                }
            }
        }
        private void btn_BajaRubro_Click(object sender, EventArgs e)
        {
            if (dgv_BancoRubros.SelectedRows != null)
            {
                int idRubroSeleccionado = (int)dgv_BancoRubros.SelectedRows[0].Cells["IdRubro"].Value;
                Rubro rubroSeleccionado = listaRubrosMemoria.FirstOrDefault(p => p.IdRubro == idRubroSeleccionado);
                if (rubroSeleccionado != null)
                {
                    if (rubroSeleccionado.CantidadProductosAsignados > 0)
                    {
                        MessageBox.Show($"El rubro {rubroSeleccionado.NombreRubro} tiene {rubroSeleccionado.CantidadProductosAsignados} productos asignados eliminelos antes de borrar el rubro");
                    }
                    else
                    {
                        rubroSeleccionado.Activo = false;
                        string jsonString = JsonSerializer.Serialize(listaRubrosMemoria);
                        File.WriteAllText("Rubros.json", jsonString);
                        CargarListaRubrosMemoriaFiltrada();
                        ActualizarDgv();
                    }
                }
            }
        }
        private void FormGestionarRubro_Load(object sender, EventArgs e)
        {
            CargarListaRubrosMemoriaFiltrada();
            AsignarProductosRubro();
            ActualizarDgv();
            LimpiarCampos();      
        }
        private void dgv_BancoRubros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_BancoRubros.SelectedRows.Count > 0)
            {
                if (dgv_BancoRubros.SelectedRows[0].Cells[0].Value == null) return;
                int idRubroSeleccionado = (int)dgv_BancoRubros.SelectedRows[0].Cells[0].Value;
                Rubro rubroSeleccionado = listaRubrosMemoria.FirstOrDefault(p => p.IdRubro == idRubroSeleccionado);
                if (rubroSeleccionado != null)
                {
                    txt_NombreRubro.Text = rubroSeleccionado.NombreRubro;
                    txt_DescripcionRubro.Text = rubroSeleccionado.DescripcionRubro;
                }
            }
        }
    }
}
