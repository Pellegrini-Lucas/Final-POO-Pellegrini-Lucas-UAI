namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    partial class FormMenuPrincipal
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
            this.btn_AbrirFormGestionProductos = new System.Windows.Forms.Button();
            this.btn_AbrirFormGestionarRubro = new System.Windows.Forms.Button();
            this.btn_AbrirFormGestionarProveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AbrirFormGestionProductos
            // 
            this.btn_AbrirFormGestionProductos.Location = new System.Drawing.Point(12, 12);
            this.btn_AbrirFormGestionProductos.Name = "btn_AbrirFormGestionProductos";
            this.btn_AbrirFormGestionProductos.Size = new System.Drawing.Size(127, 23);
            this.btn_AbrirFormGestionProductos.TabIndex = 0;
            this.btn_AbrirFormGestionProductos.Text = "Gestionar Productos";
            this.btn_AbrirFormGestionProductos.UseVisualStyleBackColor = true;
            this.btn_AbrirFormGestionProductos.Click += new System.EventHandler(this.btn_AbrirFormGestionProductos_Click);
            // 
            // btn_AbrirFormGestionarRubro
            // 
            this.btn_AbrirFormGestionarRubro.Location = new System.Drawing.Point(12, 41);
            this.btn_AbrirFormGestionarRubro.Name = "btn_AbrirFormGestionarRubro";
            this.btn_AbrirFormGestionarRubro.Size = new System.Drawing.Size(127, 23);
            this.btn_AbrirFormGestionarRubro.TabIndex = 1;
            this.btn_AbrirFormGestionarRubro.Text = "Gestionar Rubro";
            this.btn_AbrirFormGestionarRubro.UseVisualStyleBackColor = true;
            this.btn_AbrirFormGestionarRubro.Click += new System.EventHandler(this.btn_AbrirFormGestionarRubro_Click);
            // 
            // btn_AbrirFormGestionarProveedores
            // 
            this.btn_AbrirFormGestionarProveedores.Location = new System.Drawing.Point(12, 70);
            this.btn_AbrirFormGestionarProveedores.Name = "btn_AbrirFormGestionarProveedores";
            this.btn_AbrirFormGestionarProveedores.Size = new System.Drawing.Size(127, 23);
            this.btn_AbrirFormGestionarProveedores.TabIndex = 2;
            this.btn_AbrirFormGestionarProveedores.Text = "Gestionar Proveedores";
            this.btn_AbrirFormGestionarProveedores.UseVisualStyleBackColor = true;
            this.btn_AbrirFormGestionarProveedores.Click += new System.EventHandler(this.btn_AbrirFormGestionarProveedores_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AbrirFormGestionarProveedores);
            this.Controls.Add(this.btn_AbrirFormGestionarRubro);
            this.Controls.Add(this.btn_AbrirFormGestionProductos);
            this.Name = "FormMenuPrincipal";
            this.Text = "FormMenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AbrirFormGestionProductos;
        private System.Windows.Forms.Button btn_AbrirFormGestionarRubro;
        private System.Windows.Forms.Button btn_AbrirFormGestionarProveedores;
    }
}