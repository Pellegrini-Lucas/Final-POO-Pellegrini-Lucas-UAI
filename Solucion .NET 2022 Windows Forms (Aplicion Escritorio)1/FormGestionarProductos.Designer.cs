namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    partial class FormGestionarProductos
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
            this.dgv_BancoProductos = new System.Windows.Forms.DataGridView();
            this.btn_AgregarProductos = new System.Windows.Forms.Button();
            this.txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.txt_DescripcionProducto = new System.Windows.Forms.TextBox();
            this.txt_PrecioCompraProducto = new System.Windows.Forms.TextBox();
            this.txt_StockProducto = new System.Windows.Forms.TextBox();
            this.lbl_NombreProducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ModificarProductos = new System.Windows.Forms.Button();
            this.btn_BajaProductos = new System.Windows.Forms.Button();
            this.txt_BuscarNombreProducto = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Vencimiento = new System.Windows.Forms.Label();
            this.dtp_VencimientoStockIngresanteEgresante = new System.Windows.Forms.DateTimePicker();
            this.rbt_NoPerecedero = new System.Windows.Forms.RadioButton();
            this.rbt_Perecedero = new System.Windows.Forms.RadioButton();
            this.cmb_RubroProducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BancoProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_BancoProductos
            // 
            this.dgv_BancoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BancoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BancoProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BancoProductos.Location = new System.Drawing.Point(0, 0);
            this.dgv_BancoProductos.Name = "dgv_BancoProductos";
            this.dgv_BancoProductos.Size = new System.Drawing.Size(776, 687);
            this.dgv_BancoProductos.TabIndex = 11;
            this.dgv_BancoProductos.SelectionChanged += new System.EventHandler(this.dgv_BancoProductos_SelectionChanged);
            // 
            // btn_AgregarProductos
            // 
            this.btn_AgregarProductos.Location = new System.Drawing.Point(12, 15);
            this.btn_AgregarProductos.Name = "btn_AgregarProductos";
            this.btn_AgregarProductos.Size = new System.Drawing.Size(110, 23);
            this.btn_AgregarProductos.TabIndex = 0;
            this.btn_AgregarProductos.Text = "Agregar Productos";
            this.btn_AgregarProductos.UseVisualStyleBackColor = true;
            this.btn_AgregarProductos.Click += new System.EventHandler(this.btn_AgregarProductos_Click);
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Location = new System.Drawing.Point(12, 147);
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(195, 20);
            this.txt_NombreProducto.TabIndex = 1;
            // 
            // txt_DescripcionProducto
            // 
            this.txt_DescripcionProducto.Location = new System.Drawing.Point(12, 196);
            this.txt_DescripcionProducto.Name = "txt_DescripcionProducto";
            this.txt_DescripcionProducto.Size = new System.Drawing.Size(195, 20);
            this.txt_DescripcionProducto.TabIndex = 2;
            // 
            // txt_PrecioCompraProducto
            // 
            this.txt_PrecioCompraProducto.Location = new System.Drawing.Point(12, 245);
            this.txt_PrecioCompraProducto.Name = "txt_PrecioCompraProducto";
            this.txt_PrecioCompraProducto.Size = new System.Drawing.Size(195, 20);
            this.txt_PrecioCompraProducto.TabIndex = 3;
            // 
            // txt_StockProducto
            // 
            this.txt_StockProducto.Location = new System.Drawing.Point(12, 294);
            this.txt_StockProducto.Name = "txt_StockProducto";
            this.txt_StockProducto.Size = new System.Drawing.Size(195, 20);
            this.txt_StockProducto.TabIndex = 4;
            // 
            // lbl_NombreProducto
            // 
            this.lbl_NombreProducto.AutoSize = true;
            this.lbl_NombreProducto.Location = new System.Drawing.Point(9, 131);
            this.lbl_NombreProducto.Name = "lbl_NombreProducto";
            this.lbl_NombreProducto.Size = new System.Drawing.Size(90, 13);
            this.lbl_NombreProducto.TabIndex = 6;
            this.lbl_NombreProducto.Text = "Nombre Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio De Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stock Inicial Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rubro";
            // 
            // btn_ModificarProductos
            // 
            this.btn_ModificarProductos.Location = new System.Drawing.Point(12, 44);
            this.btn_ModificarProductos.Name = "btn_ModificarProductos";
            this.btn_ModificarProductos.Size = new System.Drawing.Size(109, 23);
            this.btn_ModificarProductos.TabIndex = 12;
            this.btn_ModificarProductos.Text = "Modificar Productos";
            this.btn_ModificarProductos.UseVisualStyleBackColor = true;
            this.btn_ModificarProductos.Click += new System.EventHandler(this.btn_ModificarProductos_Click);
            // 
            // btn_BajaProductos
            // 
            this.btn_BajaProductos.Location = new System.Drawing.Point(12, 73);
            this.btn_BajaProductos.Name = "btn_BajaProductos";
            this.btn_BajaProductos.Size = new System.Drawing.Size(109, 23);
            this.btn_BajaProductos.TabIndex = 13;
            this.btn_BajaProductos.Text = "Eliminar Productos";
            this.btn_BajaProductos.UseVisualStyleBackColor = true;
            this.btn_BajaProductos.Click += new System.EventHandler(this.btn_BajaProductos_Click);
            // 
            // txt_BuscarNombreProducto
            // 
            this.txt_BuscarNombreProducto.Location = new System.Drawing.Point(12, 529);
            this.txt_BuscarNombreProducto.Name = "txt_BuscarNombreProducto";
            this.txt_BuscarNombreProducto.Size = new System.Drawing.Size(195, 20);
            this.txt_BuscarNombreProducto.TabIndex = 14;
            this.txt_BuscarNombreProducto.TextChanged += new System.EventHandler(this.txt_BuscarNombreProducto_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_RubroProducto);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btn_AgregarProductos);
            this.splitContainer1.Panel1.Controls.Add(this.txt_BuscarNombreProducto);
            this.splitContainer1.Panel1.Controls.Add(this.txt_NombreProducto);
            this.splitContainer1.Panel1.Controls.Add(this.btn_BajaProductos);
            this.splitContainer1.Panel1.Controls.Add(this.txt_DescripcionProducto);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ModificarProductos);
            this.splitContainer1.Panel1.Controls.Add(this.txt_PrecioCompraProducto);
            this.splitContainer1.Panel1.Controls.Add(this.txt_StockProducto);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_NombreProducto);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_BancoProductos);
            this.splitContainer1.Size = new System.Drawing.Size(1030, 687);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Vencimiento);
            this.groupBox1.Controls.Add(this.dtp_VencimientoStockIngresanteEgresante);
            this.groupBox1.Controls.Add(this.rbt_NoPerecedero);
            this.groupBox1.Controls.Add(this.rbt_Perecedero);
            this.groupBox1.Location = new System.Drawing.Point(12, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 132);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "El producto es perecedero?";
            // 
            // lbl_Vencimiento
            // 
            this.lbl_Vencimiento.AutoSize = true;
            this.lbl_Vencimiento.Location = new System.Drawing.Point(1, 63);
            this.lbl_Vencimiento.Name = "lbl_Vencimiento";
            this.lbl_Vencimiento.Size = new System.Drawing.Size(112, 13);
            this.lbl_Vencimiento.TabIndex = 3;
            this.lbl_Vencimiento.Text = "Fecha de vencimiento";
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
            // cmb_RubroProducto
            // 
            this.cmb_RubroProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_RubroProducto.FormattingEnabled = true;
            this.cmb_RubroProducto.Location = new System.Drawing.Point(12, 480);
            this.cmb_RubroProducto.Name = "cmb_RubroProducto";
            this.cmb_RubroProducto.Size = new System.Drawing.Size(195, 21);
            this.cmb_RubroProducto.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Buscar";
            // 
            // FormGestionarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 687);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormGestionarProductos";
            this.Text = "Gestor de productos";
            this.Load += new System.EventHandler(this.FormGestionarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BancoProductos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_BancoProductos;
        private System.Windows.Forms.Button btn_AgregarProductos;
        private System.Windows.Forms.TextBox txt_NombreProducto;
        private System.Windows.Forms.TextBox txt_DescripcionProducto;
        private System.Windows.Forms.TextBox txt_PrecioCompraProducto;
        private System.Windows.Forms.TextBox txt_StockProducto;
        private System.Windows.Forms.Label lbl_NombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ModificarProductos;
        private System.Windows.Forms.Button btn_BajaProductos;
        private System.Windows.Forms.TextBox txt_BuscarNombreProducto;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_RubroProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Vencimiento;
        private System.Windows.Forms.DateTimePicker dtp_VencimientoStockIngresanteEgresante;
        private System.Windows.Forms.RadioButton rbt_NoPerecedero;
        private System.Windows.Forms.RadioButton rbt_Perecedero;
    }
}