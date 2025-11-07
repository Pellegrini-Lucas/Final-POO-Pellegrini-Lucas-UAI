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
    public partial class CustomDialog : Form
    {
        public MotivoEgreso MotivoSeleccionado { get; private set; }
        public CustomDialog()
        {
            InitializeComponent();
            this.MotivoSeleccionado = MotivoEgreso.NoSeleccionado;
        }


        private void btn_Venta_Click(object sender, EventArgs e)
        {
            this.MotivoSeleccionado = MotivoEgreso.Venta;
            this.Close();
        }

        private void btn_Merma_Click(object sender, EventArgs e)
        {
            this.MotivoSeleccionado = MotivoEgreso.Merma;
            this.Close();
        }
    }
}
