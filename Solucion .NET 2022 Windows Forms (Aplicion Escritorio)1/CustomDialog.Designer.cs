namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    partial class CustomDialog
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
            this.btn_Venta = new System.Windows.Forms.Button();
            this.btn_Merma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Venta
            // 
            this.btn_Venta.Location = new System.Drawing.Point(12, 89);
            this.btn_Venta.Name = "btn_Venta";
            this.btn_Venta.Size = new System.Drawing.Size(75, 23);
            this.btn_Venta.TabIndex = 0;
            this.btn_Venta.Text = "Venta";
            this.btn_Venta.UseVisualStyleBackColor = true;
            this.btn_Venta.Click += new System.EventHandler(this.btn_Venta_Click);
            // 
            // btn_Merma
            // 
            this.btn_Merma.Location = new System.Drawing.Point(131, 89);
            this.btn_Merma.Name = "btn_Merma";
            this.btn_Merma.Size = new System.Drawing.Size(75, 23);
            this.btn_Merma.TabIndex = 1;
            this.btn_Merma.Text = "Merma";
            this.btn_Merma.UseVisualStyleBackColor = true;
            this.btn_Merma.Click += new System.EventHandler(this.btn_Merma_Click);
            // 
            // CustomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 124);
            this.Controls.Add(this.btn_Merma);
            this.Controls.Add(this.btn_Venta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CustomDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Venta;
        private System.Windows.Forms.Button btn_Merma;
    }
}