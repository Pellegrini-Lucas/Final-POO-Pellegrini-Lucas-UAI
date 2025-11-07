namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    partial class FormGestionarStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmb_FiltroMovTipo = new System.Windows.Forms.ComboBox();
            this.dtp_FiltroFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.cmb_FiltroMovProductos = new System.Windows.Forms.ComboBox();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.cmb_OpcionesDeFiltrado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_EgresoStock = new System.Windows.Forms.Button();
            this.dtp_FechaIngresoEgresoStock = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_IngresarStock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_VencimientoStockIngresanteEgresante = new System.Windows.Forms.DateTimePicker();
            this.rbt_NoPerecedero = new System.Windows.Forms.RadioButton();
            this.rbt_Perecedero = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CantidadStockIngresanteEgresante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_ProveedorStockIngresanteEgresante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ProductoStockIngresanteEgresante = new System.Windows.Forms.ComboBox();
            this.dgv_IngresosEgresos = new System.Windows.Forms.DataGridView();
            this.dtp_FiltroFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaHasta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IngresosEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbl_FechaHasta);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_FiltroFechaHasta);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_FiltroMovTipo);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_FiltroFechaDesde);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_FiltroMovProductos);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Filtro);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_OpcionesDeFiltrado);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btn_EgresoStock);
            this.splitContainer1.Panel1.Controls.Add(this.dtp_FechaIngresoEgresoStock);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btn_IngresarStock);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txt_CantidadStockIngresanteEgresante);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_ProveedorStockIngresanteEgresante);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_ProductoStockIngresanteEgresante);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_IngresosEgresos);
            this.splitContainer1.Size = new System.Drawing.Size(1289, 682);
            this.splitContainer1.SplitterDistance = 427;
            this.splitContainer1.TabIndex = 0;
            // 
            // cmb_FiltroMovTipo
            // 
            this.cmb_FiltroMovTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltroMovTipo.FormattingEnabled = true;
            this.cmb_FiltroMovTipo.Location = new System.Drawing.Point(12, 500);
            this.cmb_FiltroMovTipo.Name = "cmb_FiltroMovTipo";
            this.cmb_FiltroMovTipo.Size = new System.Drawing.Size(121, 21);
            this.cmb_FiltroMovTipo.TabIndex = 15;
            this.cmb_FiltroMovTipo.Visible = false;
            this.cmb_FiltroMovTipo.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltroMovTipo_SelectedIndexChanged);
            // 
            // dtp_FiltroFechaDesde
            // 
            this.dtp_FiltroFechaDesde.Location = new System.Drawing.Point(12, 501);
            this.dtp_FiltroFechaDesde.Name = "dtp_FiltroFechaDesde";
            this.dtp_FiltroFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtp_FiltroFechaDesde.TabIndex = 14;
            this.dtp_FiltroFechaDesde.Visible = false;
            this.dtp_FiltroFechaDesde.ValueChanged += new System.EventHandler(this.dtp_FiltroFechaDesde_ValueChanged);
            // 
            // cmb_FiltroMovProductos
            // 
            this.cmb_FiltroMovProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltroMovProductos.FormattingEnabled = true;
            this.cmb_FiltroMovProductos.Location = new System.Drawing.Point(12, 499);
            this.cmb_FiltroMovProductos.Name = "cmb_FiltroMovProductos";
            this.cmb_FiltroMovProductos.Size = new System.Drawing.Size(121, 21);
            this.cmb_FiltroMovProductos.TabIndex = 13;
            this.cmb_FiltroMovProductos.Visible = false;
            this.cmb_FiltroMovProductos.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltroMovProductos_SelectedIndexChanged);
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Location = new System.Drawing.Point(9, 485);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(35, 13);
            this.lbl_Filtro.TabIndex = 12;
            this.lbl_Filtro.Text = "label7";
            this.lbl_Filtro.Visible = false;
            // 
            // cmb_OpcionesDeFiltrado
            // 
            this.cmb_OpcionesDeFiltrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_OpcionesDeFiltrado.FormattingEnabled = true;
            this.cmb_OpcionesDeFiltrado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_OpcionesDeFiltrado.Location = new System.Drawing.Point(12, 454);
            this.cmb_OpcionesDeFiltrado.Name = "cmb_OpcionesDeFiltrado";
            this.cmb_OpcionesDeFiltrado.Size = new System.Drawing.Size(171, 21);
            this.cmb_OpcionesDeFiltrado.TabIndex = 11;
            this.cmb_OpcionesDeFiltrado.SelectedIndexChanged += new System.EventHandler(this.cmb_OpcionesDeFiltrado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Filtrar por...";
            // 
            // btn_EgresoStock
            // 
            this.btn_EgresoStock.Location = new System.Drawing.Point(13, 42);
            this.btn_EgresoStock.Name = "btn_EgresoStock";
            this.btn_EgresoStock.Size = new System.Drawing.Size(112, 23);
            this.btn_EgresoStock.TabIndex = 9;
            this.btn_EgresoStock.Text = "Egresar Stock";
            this.btn_EgresoStock.UseVisualStyleBackColor = true;
            this.btn_EgresoStock.Click += new System.EventHandler(this.btn_EgresoStock_Click);
            // 
            // dtp_FechaIngresoEgresoStock
            // 
            this.dtp_FechaIngresoEgresoStock.Location = new System.Drawing.Point(13, 404);
            this.dtp_FechaIngresoEgresoStock.Name = "dtp_FechaIngresoEgresoStock";
            this.dtp_FechaIngresoEgresoStock.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaIngresoEgresoStock.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Ingreso/Egreso";
            // 
            // btn_IngresarStock
            // 
            this.btn_IngresarStock.Location = new System.Drawing.Point(13, 13);
            this.btn_IngresarStock.Name = "btn_IngresarStock";
            this.btn_IngresarStock.Size = new System.Drawing.Size(112, 23);
            this.btn_IngresarStock.TabIndex = 7;
            this.btn_IngresarStock.Text = "Ingresar Stock";
            this.btn_IngresarStock.UseVisualStyleBackColor = true;
            this.btn_IngresarStock.Click += new System.EventHandler(this.btn_IngresarStock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_VencimientoStockIngresanteEgresante);
            this.groupBox1.Controls.Add(this.rbt_NoPerecedero);
            this.groupBox1.Controls.Add(this.rbt_Perecedero);
            this.groupBox1.Location = new System.Drawing.Point(12, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "El producto es perecedero?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de vencimiento";
            // 
            // dtp_VencimientoStockIngresanteEgresante
            // 
            this.dtp_VencimientoStockIngresanteEgresante.Location = new System.Drawing.Point(0, 79);
            this.dtp_VencimientoStockIngresanteEgresante.Name = "dtp_VencimientoStockIngresanteEgresante";
            this.dtp_VencimientoStockIngresanteEgresante.Size = new System.Drawing.Size(200, 20);
            this.dtp_VencimientoStockIngresanteEgresante.TabIndex = 2;
            // 
            // rbt_NoPerecedero
            // 
            this.rbt_NoPerecedero.AutoSize = true;
            this.rbt_NoPerecedero.Location = new System.Drawing.Point(7, 43);
            this.rbt_NoPerecedero.Name = "rbt_NoPerecedero";
            this.rbt_NoPerecedero.Size = new System.Drawing.Size(39, 17);
            this.rbt_NoPerecedero.TabIndex = 1;
            this.rbt_NoPerecedero.TabStop = true;
            this.rbt_NoPerecedero.Text = "No";
            this.rbt_NoPerecedero.UseVisualStyleBackColor = true;
            // 
            // rbt_Perecedero
            // 
            this.rbt_Perecedero.AutoSize = true;
            this.rbt_Perecedero.Location = new System.Drawing.Point(7, 20);
            this.rbt_Perecedero.Name = "rbt_Perecedero";
            this.rbt_Perecedero.Size = new System.Drawing.Size(34, 17);
            this.rbt_Perecedero.TabIndex = 0;
            this.rbt_Perecedero.TabStop = true;
            this.rbt_Perecedero.Text = "Si";
            this.rbt_Perecedero.UseVisualStyleBackColor = true;
            this.rbt_Perecedero.CheckedChanged += new System.EventHandler(this.rbt_Perecedero_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad";
            // 
            // txt_CantidadStockIngresanteEgresante
            // 
            this.txt_CantidadStockIngresanteEgresante.Location = new System.Drawing.Point(12, 227);
            this.txt_CantidadStockIngresanteEgresante.Name = "txt_CantidadStockIngresanteEgresante";
            this.txt_CantidadStockIngresanteEgresante.Size = new System.Drawing.Size(100, 20);
            this.txt_CantidadStockIngresanteEgresante.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proveedor";
            // 
            // cmb_ProveedorStockIngresanteEgresante
            // 
            this.cmb_ProveedorStockIngresanteEgresante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ProveedorStockIngresanteEgresante.FormattingEnabled = true;
            this.cmb_ProveedorStockIngresanteEgresante.Location = new System.Drawing.Point(12, 187);
            this.cmb_ProveedorStockIngresanteEgresante.Name = "cmb_ProveedorStockIngresanteEgresante";
            this.cmb_ProveedorStockIngresanteEgresante.Size = new System.Drawing.Size(159, 21);
            this.cmb_ProveedorStockIngresanteEgresante.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto ";
            // 
            // cmb_ProductoStockIngresanteEgresante
            // 
            this.cmb_ProductoStockIngresanteEgresante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ProductoStockIngresanteEgresante.FormattingEnabled = true;
            this.cmb_ProductoStockIngresanteEgresante.Location = new System.Drawing.Point(12, 147);
            this.cmb_ProductoStockIngresanteEgresante.Name = "cmb_ProductoStockIngresanteEgresante";
            this.cmb_ProductoStockIngresanteEgresante.Size = new System.Drawing.Size(159, 21);
            this.cmb_ProductoStockIngresanteEgresante.TabIndex = 0;
            // 
            // dgv_IngresosEgresos
            // 
            this.dgv_IngresosEgresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_IngresosEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IngresosEgresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_IngresosEgresos.Location = new System.Drawing.Point(0, 0);
            this.dgv_IngresosEgresos.Name = "dgv_IngresosEgresos";
            this.dgv_IngresosEgresos.Size = new System.Drawing.Size(858, 682);
            this.dgv_IngresosEgresos.TabIndex = 12;
            // 
            // dtp_FiltroFechaHasta
            // 
            this.dtp_FiltroFechaHasta.Location = new System.Drawing.Point(12, 538);
            this.dtp_FiltroFechaHasta.Name = "dtp_FiltroFechaHasta";
            this.dtp_FiltroFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_FiltroFechaHasta.TabIndex = 16;
            this.dtp_FiltroFechaHasta.Visible = false;
            this.dtp_FiltroFechaHasta.ValueChanged += new System.EventHandler(this.dtp_FiltroFechaHasta_ValueChanged);
            // 
            // lbl_FechaHasta
            // 
            this.lbl_FechaHasta.AutoSize = true;
            this.lbl_FechaHasta.Location = new System.Drawing.Point(10, 524);
            this.lbl_FechaHasta.Name = "lbl_FechaHasta";
            this.lbl_FechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lbl_FechaHasta.TabIndex = 17;
            this.lbl_FechaHasta.Text = "label7";
            this.lbl_FechaHasta.Visible = false;
            // 
            // FormGestionarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 682);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormGestionarStock";
            this.Text = "FormGestionarStock";
            this.Load += new System.EventHandler(this.FormGestionarStock_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IngresosEgresos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cmb_ProductoStockIngresanteEgresante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_IngresosEgresos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CantidadStockIngresanteEgresante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_VencimientoStockIngresanteEgresante;
        private System.Windows.Forms.RadioButton rbt_NoPerecedero;
        private System.Windows.Forms.RadioButton rbt_Perecedero;
        private System.Windows.Forms.Button btn_IngresarStock;
        private System.Windows.Forms.DateTimePicker dtp_FechaIngresoEgresoStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_EgresoStock;
        private System.Windows.Forms.ComboBox cmb_ProveedorStockIngresanteEgresante;
        private System.Windows.Forms.ComboBox cmb_OpcionesDeFiltrado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.ComboBox cmb_FiltroMovTipo;
        private System.Windows.Forms.DateTimePicker dtp_FiltroFechaDesde;
        private System.Windows.Forms.ComboBox cmb_FiltroMovProductos;
        private System.Windows.Forms.DateTimePicker dtp_FiltroFechaHasta;
        private System.Windows.Forms.Label lbl_FechaHasta;
    }
}