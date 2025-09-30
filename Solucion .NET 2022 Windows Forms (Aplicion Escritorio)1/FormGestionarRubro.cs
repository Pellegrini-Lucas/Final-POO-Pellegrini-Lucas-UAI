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
        List <Rubro> listaRubrosMemoria = new List <Rubro>();
        List<Rubro> listaRubrosMemoriaFiltrada = new List<Rubro>();
        private int GenerarIdProducto()
        {
            if (listaRubrosMemoria.Count == 0)
                return 1;
            return listaRubrosMemoria.Max(p => p.Id) + 1;
        }
        private void CargarListaMemoriaFiltrada()
        {
            if (!File.Exists("Rubros.json"))
            {
                File.Create("Rubros.json");
            }
            string JsonString = File.ReadAllText("Rubros.json");
            if (string.IsNullOrWhiteSpace("Rubros.json"))
            {
                listaRubrosMemoria = new List<Rubro>();
            }
            else
            {
                listaRubrosMemoria = JsonSerializer.Deserialize<List<Rubro>>(JsonString);
                listaRubrosMemoriaFiltrada = listaRubrosMemoria.Where(p => p.Activo = true).ToList();
            }    
        }
        private void ActualizarDgv()
        {
            dgv_BancoRubros.AutoGenerateColumns = false;
            dgv_BancoRubros.MultiSelect = false;
            dgv_BancoRubros.ReadOnly = true;
            dgv_BancoRubros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_BancoRubros.Columns.Clear();

            dgv_BancoRubros.Columns.Add("Id", "ID");
            dgv_BancoRubros.Columns["ID"].DataPropertyName = "Id";

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
            Rubro nuevoRubro = new Rubro();
            nuevoRubro.Id = GenerarIdProducto();
            nuevoRubro.NombreRubro = txt_NombreRubro.Text;
            nuevoRubro.DescripcionRubro = txt_DescripcionRubro.Text;
            nuevoRubro.CantidadProductosAsignados = 0;
            listaRubrosMemoria.Add(nuevoRubro);
            string JsonString = JsonSerializer.Serialize(listaRubrosMemoria);
            File.WriteAllText("Rubros.json",JsonString);
            CargarListaMemoriaFiltrada();
            ActualizarDgv();    
        }

        private void btn_ModificarRubro_Click(object sender, EventArgs e)
        {
            if (dgv_BancoRubros.SelectedRows != null)
            {
                int idRubroSeleccionado = (int)dgv_BancoRubros.SelectedRows[0].Cells["Id"].Value;
                Rubro rubro = listaRubrosMemoria.FirstOrDefault(p => p.Id == idRubroSeleccionado);

            }
        }

        private void btn_BajaRubro_Click(object sender, EventArgs e)
        {

        }

        private void FormGestionarRubro_Load(object sender, EventArgs e)
        {
            CargarListaMemoriaFiltrada();
            ActualizarDgv();
        }
    }
}
