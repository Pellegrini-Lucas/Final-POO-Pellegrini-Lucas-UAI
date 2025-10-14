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
            this.txt_PrecioUnitarioProducto = new System.Windows.Forms.TextBox();
            this.txt_StockProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ModificarProductos = new System.Windows.Forms.Button();
            this.btn_BajaProductos = new System.Windows.Forms.Button();
            this.txt_BuscarNombreProducto = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmb_RubroProducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BancoProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_BancoProductos
            // 
            this.dgv_BancoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BancoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BancoProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BancoProductos.Location = new System.Drawing.Point(0, 0);
            this.dgv_BancoProductos.Name = "dgv_BancoProductos";
            this.dgv_BancoProductos.Size = new System.Drawing.Size(776, 527);
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
            // txt_PrecioUnitarioProducto
            // 
            this.txt_PrecioUnitarioProducto.Location = new System.Drawing.Point(12, 245);
            this.txt_PrecioUnitarioProducto.Name = "txt_PrecioUnitarioProducto";
            this.txt_PrecioUnitarioProducto.Size = new System.Drawing.Size(195, 20);
            this.txt_PrecioUnitarioProducto.TabIndex = 3;
            // 
            // txt_StockProducto
            // 
            this.txt_StockProducto.Location = new System.Drawing.Point(12, 294);
            this.txt_StockProducto.Name = "txt_StockProducto";
            this.txt_StockProducto.Size = new System.Drawing.Size(195, 20);
            this.txt_StockProducto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Producto";
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
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio Unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stock Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 327);
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
            this.txt_BuscarNombreProducto.Location = new System.Drawing.Point(12, 392);
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
            this.splitContainer1.Panel1.Controls.Add(this.cmb_RubroProducto);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btn_AgregarProductos);
            this.splitContainer1.Panel1.Controls.Add(this.txt_BuscarNombreProducto);
            this.splitContainer1.Panel1.Controls.Add(this.txt_NombreProducto);
            this.splitContainer1.Panel1.Controls.Add(this.btn_BajaProductos);
            this.splitContainer1.Panel1.Controls.Add(this.txt_DescripcionProducto);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ModificarProductos);
            this.splitContainer1.Panel1.Controls.Add(this.txt_PrecioUnitarioProducto);
            this.splitContainer1.Panel1.Controls.Add(this.txt_StockProducto);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_BancoProductos);
            this.splitContainer1.Size = new System.Drawing.Size(1030, 527);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 15;
            // 
            // cmb_RubroProducto
            // 
            this.cmb_RubroProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_RubroProducto.FormattingEnabled = true;
            this.cmb_RubroProducto.Location = new System.Drawing.Point(12, 344);
            this.cmb_RubroProducto.Name = "cmb_RubroProducto";
            this.cmb_RubroProducto.Size = new System.Drawing.Size(195, 21);
            this.cmb_RubroProducto.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Buscar";
            // 
            // FormGestionarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 527);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_BancoProductos;
        private System.Windows.Forms.Button btn_AgregarProductos;
        private System.Windows.Forms.TextBox txt_NombreProducto;
        private System.Windows.Forms.TextBox txt_DescripcionProducto;
        private System.Windows.Forms.TextBox txt_PrecioUnitarioProducto;
        private System.Windows.Forms.TextBox txt_StockProducto;
        private System.Windows.Forms.Label label1;
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
    }
}