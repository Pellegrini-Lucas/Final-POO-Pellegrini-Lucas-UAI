using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_AbrirFormGestionProductos_Click(object sender, EventArgs e)
        {
            FormGestionarProductos formGestionarProductos = new FormGestionarProductos();
            formGestionarProductos.ShowDialog();
        }

        private void btn_AbrirFormGestionarRubro_Click(object sender, EventArgs e)
        {
            FormGestionarRubro formGestionarRubro = new FormGestionarRubro();
            formGestionarRubro.ShowDialog();
        }
    }
}
