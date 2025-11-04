namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    partial class FormGestionarProveedores
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
            this.btn_AgregarProveedores = new System.Windows.Forms.Button();
            this.txt_NombreProveedor = new System.Windows.Forms.TextBox();
            this.btn_BajaProveedores = new System.Windows.Forms.Button();
            this.txt_ContactoProveedor = new System.Windows.Forms.TextBox();
            this.btn_ModificarProveedores = new System.Windows.Forms.Button();
            this.txt_TelefonoProveedor = new System.Windows.Forms.TextBox();
            this.txt_DireccionProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_BancoProveedores = new System.Windows.Forms.DataGridView();
            this.txt_BuscarNombreProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BancoProveedores)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txt_BuscarNombreProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.btn_AgregarProveedores);
            this.splitContainer1.Panel1.Controls.Add(this.txt_NombreProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.btn_BajaProveedores);
            this.splitContainer1.Panel1.Controls.Add(this.txt_ContactoProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ModificarProveedores);
            this.splitContainer1.Panel1.Controls.Add(this.txt_TelefonoProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.txt_DireccionProveedor);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_BancoProveedores);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 16;
            // 
            // btn_AgregarProveedores
            // 
            this.btn_AgregarProveedores.Location = new System.Drawing.Point(12, 15);
            this.btn_AgregarProveedores.Name = "btn_AgregarProveedores";
            this.btn_AgregarProveedores.Size = new System.Drawing.Size(122, 23);
            this.btn_AgregarProveedores.TabIndex = 0;
            this.btn_AgregarProveedores.Text = "Agregar Proveedores";
            this.btn_AgregarProveedores.UseVisualStyleBackColor = true;
            this.btn_AgregarProveedores.Click += new System.EventHandler(this.btn_AgregarProveedores_Click);
            // 
            // txt_NombreProveedor
            // 
            this.txt_NombreProveedor.Location = new System.Drawing.Point(12, 147);
            this.txt_NombreProveedor.Name = "txt_NombreProveedor";
            this.txt_NombreProveedor.Size = new System.Drawing.Size(195, 20);
            this.txt_NombreProveedor.TabIndex = 1;
            // 
            // btn_BajaProveedores
            // 
            this.btn_BajaProveedores.Location = new System.Drawing.Point(12, 73);
            this.btn_BajaProveedores.Name = "btn_BajaProveedores";
            this.btn_BajaProveedores.Size = new System.Drawing.Size(122, 23);
            this.btn_BajaProveedores.TabIndex = 13;
            this.btn_BajaProveedores.Text = "Eliminar Proveedores";
            this.btn_BajaProveedores.UseVisualStyleBackColor = true;
            this.btn_BajaProveedores.Click += new System.EventHandler(this.btn_BajaProveedores_Click);
            // 
            // txt_ContactoProveedor
            // 
            this.txt_ContactoProveedor.Location = new System.Drawing.Point(12, 196);
            this.txt_ContactoProveedor.Name = "txt_ContactoProveedor";
            this.txt_ContactoProveedor.Size = new System.Drawing.Size(195, 20);
            this.txt_ContactoProveedor.TabIndex = 2;
            // 
            // btn_ModificarProveedores
            // 
            this.btn_ModificarProveedores.Location = new System.Drawing.Point(12, 44);
            this.btn_ModificarProveedores.Name = "btn_ModificarProveedores";
            this.btn_ModificarProveedores.Size = new System.Drawing.Size(122, 23);
            this.btn_ModificarProveedores.TabIndex = 12;
            this.btn_ModificarProveedores.Text = "Modificar Proveedores";
            this.btn_ModificarProveedores.UseVisualStyleBackColor = true;
            this.btn_ModificarProveedores.Click += new System.EventHandler(this.btn_ModificarProveedores_Click);
            // 
            // txt_TelefonoProveedor
            // 
            this.txt_TelefonoProveedor.Location = new System.Drawing.Point(12, 245);
            this.txt_TelefonoProveedor.MaxLength = 10;
            this.txt_TelefonoProveedor.Name = "txt_TelefonoProveedor";
            this.txt_TelefonoProveedor.Size = new System.Drawing.Size(195, 20);
            this.txt_TelefonoProveedor.TabIndex = 3;
            // 
            // txt_DireccionProveedor
            // 
            this.txt_DireccionProveedor.Location = new System.Drawing.Point(12, 294);
            this.txt_DireccionProveedor.Name = "txt_DireccionProveedor";
            this.txt_DireccionProveedor.Size = new System.Drawing.Size(195, 20);
            this.txt_DireccionProveedor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Direccion Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefono Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contacto Proveedor";
            // 
            // dgv_BancoProveedores
            // 
            this.dgv_BancoProveedores.AllowUserToAddRows = false;
            this.dgv_BancoProveedores.AllowUserToDeleteRows = false;
            this.dgv_BancoProveedores.AllowUserToResizeColumns = false;
            this.dgv_BancoProveedores.AllowUserToResizeRows = false;
            this.dgv_BancoProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BancoProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BancoProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BancoProveedores.Location = new System.Drawing.Point(0, 0);
            this.dgv_BancoProveedores.MultiSelect = false;
            this.dgv_BancoProveedores.Name = "dgv_BancoProveedores";
            this.dgv_BancoProveedores.ReadOnly = true;
            this.dgv_BancoProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_BancoProveedores.Size = new System.Drawing.Size(546, 450);
            this.dgv_BancoProveedores.TabIndex = 11;
            // 
            // txt_BuscarNombreProveedor
            // 
            this.txt_BuscarNombreProveedor.Location = new System.Drawing.Point(12, 346);
            this.txt_BuscarNombreProveedor.Name = "txt_BuscarNombreProveedor";
            this.txt_BuscarNombreProveedor.Size = new System.Drawing.Size(195, 20);
            this.txt_BuscarNombreProveedor.TabIndex = 14;
            this.txt_BuscarNombreProveedor.TextChanged += new System.EventHandler(this.txt_BuscarNombreProveedor_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Buscar";
            // 
            // FormGestionarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormGestionarProveedores";
            this.Text = "FormGestionarProveedores";
            this.Load += new System.EventHandler(this.FormGestionarProveedores_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BancoProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_AgregarProveedores;
        private System.Windows.Forms.TextBox txt_NombreProveedor;
        private System.Windows.Forms.Button btn_BajaProveedores;
        private System.Windows.Forms.TextBox txt_ContactoProveedor;
        private System.Windows.Forms.Button btn_ModificarProveedores;
        private System.Windows.Forms.TextBox txt_TelefonoProveedor;
        private System.Windows.Forms.TextBox txt_DireccionProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_BancoProveedores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_BuscarNombreProveedor;
    }
}