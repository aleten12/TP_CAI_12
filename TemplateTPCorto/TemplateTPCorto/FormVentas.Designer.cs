namespace TemplateTPCorto
{
    partial class FormVentas
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.lblCategoriaProductos = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.cbxCategoriaProductos = new System.Windows.Forms.ComboBox();
            this.lstProducto = new System.Windows.Forms.ListBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.lstCarrito = new System.Windows.Forms.ListBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCargarVenta = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotalNum = new System.Windows.Forms.Label();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(100, 72);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(79, 25);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // cbxClientes
            // 
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(217, 69);
            this.cbxClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(357, 33);
            this.cbxClientes.TabIndex = 1;
            // 
            // lblCategoriaProductos
            // 
            this.lblCategoriaProductos.AutoSize = true;
            this.lblCategoriaProductos.Location = new System.Drawing.Point(100, 151);
            this.lblCategoriaProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaProductos.Name = "lblCategoriaProductos";
            this.lblCategoriaProductos.Size = new System.Drawing.Size(206, 25);
            this.lblCategoriaProductos.TabIndex = 2;
            this.lblCategoriaProductos.Text = "Categoria productos";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(595, 141);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(160, 45);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // cbxCategoriaProductos
            // 
            this.cbxCategoriaProductos.FormattingEnabled = true;
            this.cbxCategoriaProductos.Location = new System.Drawing.Point(341, 148);
            this.cbxCategoriaProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCategoriaProductos.Name = "cbxCategoriaProductos";
            this.cbxCategoriaProductos.Size = new System.Drawing.Size(233, 33);
            this.cbxCategoriaProductos.TabIndex = 4;
            // 
            // lstProducto
            // 
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.ItemHeight = 25;
            this.lstProducto.Location = new System.Drawing.Point(105, 231);
            this.lstProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(648, 304);
            this.lstProducto.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(100, 591);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(98, 25);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(236, 588);
            this.txbCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(172, 31);
            this.txbCantidad.TabIndex = 7;
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Location = new System.Drawing.Point(267, 685);
            this.btnAgregarCarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(295, 51);
            this.btnAgregarCarrito.TabIndex = 8;
            this.btnAgregarCarrito.Text = "Agregar a carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            // 
            // lstCarrito
            // 
            this.lstCarrito.FormattingEnabled = true;
            this.lstCarrito.ItemHeight = 25;
            this.lstCarrito.Location = new System.Drawing.Point(935, 81);
            this.lstCarrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCarrito.Name = "lstCarrito";
            this.lstCarrito.Size = new System.Drawing.Size(488, 454);
            this.lstCarrito.TabIndex = 9;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(1452, 81);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(180, 49);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnCargarVenta
            // 
            this.btnCargarVenta.Location = new System.Drawing.Point(1033, 685);
            this.btnCargarVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarVenta.Name = "btnCargarVenta";
            this.btnCargarVenta.Size = new System.Drawing.Size(284, 51);
            this.btnCargarVenta.TabIndex = 11;
            this.btnCargarVenta.Text = "Cargar venta";
            this.btnCargarVenta.UseVisualStyleBackColor = true;
            this.btnCargarVenta.Click += new System.EventHandler(this.btnCargarVenta_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(929, 572);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(91, 25);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(929, 616);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 25);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total";
            // 
            // lblSubtotalNum
            // 
            this.lblSubtotalNum.AutoSize = true;
            this.lblSubtotalNum.Location = new System.Drawing.Point(1061, 572);
            this.lblSubtotalNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotalNum.Name = "lblSubtotalNum";
            this.lblSubtotalNum.Size = new System.Drawing.Size(24, 25);
            this.lblSubtotalNum.TabIndex = 14;
            this.lblSubtotalNum.Text = "0";
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Location = new System.Drawing.Point(1061, 616);
            this.lblTotalNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(24, 25);
            this.lblTotalNum.TabIndex = 15;
            this.lblTotalNum.Text = "0";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 808);
            this.Controls.Add(this.lblTotalNum);
            this.Controls.Add(this.lblSubtotalNum);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCargarVenta);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lstCarrito);
            this.Controls.Add(this.btnAgregarCarrito);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lstProducto);
            this.Controls.Add(this.cbxCategoriaProductos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblCategoriaProductos);
            this.Controls.Add(this.cbxClientes);
            this.Controls.Add(this.lblCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Label lblCategoriaProductos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cbxCategoriaProductos;
        private System.Windows.Forms.ListBox lstProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.ListBox lstCarrito;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnCargarVenta;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotalNum;
        private System.Windows.Forms.Label lblTotalNum;
    }
}