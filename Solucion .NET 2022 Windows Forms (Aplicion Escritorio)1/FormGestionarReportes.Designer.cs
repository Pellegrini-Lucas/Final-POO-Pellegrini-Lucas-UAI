namespace Solucion.NET_2022_Windows_Forms__Aplicion_Escritorio_1
{
    partial class FormGestionarReportes
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
            this.flp_StockActualPorProducto = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_StockActualPorRubro = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flp_IngresosPorProveedor = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flp_BajoStockProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.flp_LotesProntoAVencer = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flp_StockActualPorProducto
            // 
            this.flp_StockActualPorProducto.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_StockActualPorProducto.Location = new System.Drawing.Point(13, 26);
            this.flp_StockActualPorProducto.Name = "flp_StockActualPorProducto";
            this.flp_StockActualPorProducto.Size = new System.Drawing.Size(200, 209);
            this.flp_StockActualPorProducto.TabIndex = 0;
            // 
            // flp_StockActualPorRubro
            // 
            this.flp_StockActualPorRubro.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_StockActualPorRubro.Location = new System.Drawing.Point(219, 26);
            this.flp_StockActualPorRubro.Name = "flp_StockActualPorRubro";
            this.flp_StockActualPorRubro.Size = new System.Drawing.Size(200, 209);
            this.flp_StockActualPorRubro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock Actual Por Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock Actual Por Rubro";
            // 
            // flp_IngresosPorProveedor
            // 
            this.flp_IngresosPorProveedor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_IngresosPorProveedor.Location = new System.Drawing.Point(425, 26);
            this.flp_IngresosPorProveedor.Name = "flp_IngresosPorProveedor";
            this.flp_IngresosPorProveedor.Size = new System.Drawing.Size(200, 209);
            this.flp_IngresosPorProveedor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresos Totales Por Proveedor";
            // 
            // flp_BajoStockProductos
            // 
            this.flp_BajoStockProductos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_BajoStockProductos.Location = new System.Drawing.Point(13, 258);
            this.flp_BajoStockProductos.Name = "flp_BajoStockProductos";
            this.flp_BajoStockProductos.Size = new System.Drawing.Size(200, 209);
            this.flp_BajoStockProductos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Productos Con Poco Stock (Stock < 25)";
            // 
            // flp_LotesProntoAVencer
            // 
            this.flp_LotesProntoAVencer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_LotesProntoAVencer.Location = new System.Drawing.Point(219, 258);
            this.flp_LotesProntoAVencer.Name = "flp_LotesProntoAVencer";
            this.flp_LotesProntoAVencer.Size = new System.Drawing.Size(200, 209);
            this.flp_LotesProntoAVencer.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lotes Pronto A Vencer (1 semana)";
            // 
            // FormGestionarReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flp_LotesProntoAVencer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flp_BajoStockProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flp_IngresosPorProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flp_StockActualPorRubro);
            this.Controls.Add(this.flp_StockActualPorProducto);
            this.Name = "FormGestionarReportes";
            this.Text = "FormGestionarReportes";
            this.Load += new System.EventHandler(this.FormGestionarReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_StockActualPorProducto;
        private System.Windows.Forms.FlowLayoutPanel flp_StockActualPorRubro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flp_IngresosPorProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flp_BajoStockProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flp_LotesProntoAVencer;
        private System.Windows.Forms.Label label5;
    }
}