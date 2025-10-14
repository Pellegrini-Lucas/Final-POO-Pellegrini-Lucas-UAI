namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    partial class FormGestionarRubro
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
            this.btn_AgregarRubro = new System.Windows.Forms.Button();
            this.btn_ModificarRubro = new System.Windows.Forms.Button();
            this.btn_BajaRubro = new System.Windows.Forms.Button();
            this.txt_NombreRubro = new System.Windows.Forms.TextBox();
            this.txt_DescripcionRubro = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_BancoRubros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BancoRubros)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarRubro
            // 
            this.btn_AgregarRubro.Location = new System.Drawing.Point(12, 12);
            this.btn_AgregarRubro.Name = "btn_AgregarRubro";
            this.btn_AgregarRubro.Size = new System.Drawing.Size(110, 23);
            this.btn_AgregarRubro.TabIndex = 0;
            this.btn_AgregarRubro.Text = "Agregar rubro ";
            this.btn_AgregarRubro.UseVisualStyleBackColor = true;
            this.btn_AgregarRubro.Click += new System.EventHandler(this.btn_AgregarRubro_Click);
            // 
            // btn_ModificarRubro
            // 
            this.btn_ModificarRubro.Location = new System.Drawing.Point(12, 41);
            this.btn_ModificarRubro.Name = "btn_ModificarRubro";
            this.btn_ModificarRubro.Size = new System.Drawing.Size(110, 23);
            this.btn_ModificarRubro.TabIndex = 1;
            this.btn_ModificarRubro.Text = "Modificar rubro";
            this.btn_ModificarRubro.UseVisualStyleBackColor = true;
            this.btn_ModificarRubro.Click += new System.EventHandler(this.btn_ModificarRubro_Click);
            // 
            // btn_BajaRubro
            // 
            this.btn_BajaRubro.Location = new System.Drawing.Point(12, 70);
            this.btn_BajaRubro.Name = "btn_BajaRubro";
            this.btn_BajaRubro.Size = new System.Drawing.Size(110, 23);
            this.btn_BajaRubro.TabIndex = 2;
            this.btn_BajaRubro.Text = "Eliiminar rubro";
            this.btn_BajaRubro.UseVisualStyleBackColor = true;
            this.btn_BajaRubro.Click += new System.EventHandler(this.btn_BajaRubro_Click);
            // 
            // txt_NombreRubro
            // 
            this.txt_NombreRubro.Location = new System.Drawing.Point(12, 116);
            this.txt_NombreRubro.Name = "txt_NombreRubro";
            this.txt_NombreRubro.Size = new System.Drawing.Size(195, 20);
            this.txt_NombreRubro.TabIndex = 3;
            // 
            // txt_DescripcionRubro
            // 
            this.txt_DescripcionRubro.Location = new System.Drawing.Point(12, 165);
            this.txt_DescripcionRubro.Name = "txt_DescripcionRubro";
            this.txt_DescripcionRubro.Size = new System.Drawing.Size(195, 20);
            this.txt_DescripcionRubro.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_AgregarRubro);
            this.splitContainer1.Panel1.Controls.Add(this.txt_DescripcionRubro);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ModificarRubro);
            this.splitContainer1.Panel1.Controls.Add(this.txt_NombreRubro);
            this.splitContainer1.Panel1.Controls.Add(this.btn_BajaRubro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_BancoRubros);
            this.splitContainer1.Size = new System.Drawing.Size(957, 530);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion del rubro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del rubro";
            // 
            // dgv_BancoRubros
            // 
            this.dgv_BancoRubros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BancoRubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BancoRubros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BancoRubros.Location = new System.Drawing.Point(0, 0);
            this.dgv_BancoRubros.Name = "dgv_BancoRubros";
            this.dgv_BancoRubros.Size = new System.Drawing.Size(654, 530);
            this.dgv_BancoRubros.TabIndex = 0;
            this.dgv_BancoRubros.SelectionChanged += new System.EventHandler(this.dgv_BancoRubros_SelectionChanged);
            // 
            // FormGestionarRubro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 530);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormGestionarRubro";
            this.Text = "FormGestionarRubro";
            this.Load += new System.EventHandler(this.FormGestionarRubro_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BancoRubros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarRubro;
        private System.Windows.Forms.Button btn_ModificarRubro;
        private System.Windows.Forms.Button btn_BajaRubro;
        private System.Windows.Forms.TextBox txt_NombreRubro;
        private System.Windows.Forms.TextBox txt_DescripcionRubro;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_BancoRubros;
    }
}