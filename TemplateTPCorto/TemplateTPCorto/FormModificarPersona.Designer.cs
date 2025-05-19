namespace TemplateTPCorto
{
    partial class FormModificarPersona
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
            this.lblLegajo = new System.Windows.Forms.Label();
            this.cbxLegajos = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.btbGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(191, 98);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(57, 20);
            this.lblLegajo.TabIndex = 0;
            this.lblLegajo.Text = "Legajo";
            // 
            // cbxLegajos
            // 
            this.cbxLegajos.FormattingEnabled = true;
            this.cbxLegajos.Location = new System.Drawing.Point(350, 90);
            this.cbxLegajos.Name = "cbxLegajos";
            this.cbxLegajos.Size = new System.Drawing.Size(234, 28);
            this.cbxLegajos.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(191, 149);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(191, 197);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(191, 240);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(37, 20);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(350, 143);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(234, 26);
            this.txbNombre.TabIndex = 5;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(350, 191);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(234, 26);
            this.txbApellido.TabIndex = 6;
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(350, 234);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(234, 26);
            this.txbDni.TabIndex = 7;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(350, 285);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(234, 26);
            this.dtpFechaIngreso.TabIndex = 8;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(191, 290);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(132, 20);
            this.lblFechaIngreso.TabIndex = 9;
            this.lblFechaIngreso.Text = "Fecha de ingreso";
            // 
            // btbGuardar
            // 
            this.btbGuardar.Location = new System.Drawing.Point(289, 346);
            this.btbGuardar.Name = "btbGuardar";
            this.btbGuardar.Size = new System.Drawing.Size(189, 36);
            this.btbGuardar.TabIndex = 10;
            this.btbGuardar.Text = "Guardar datos";
            this.btbGuardar.UseVisualStyleBackColor = true;
            this.btbGuardar.Click += new System.EventHandler(this.btbGuardar_Click);
            // 
            // FormModificarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbGuardar);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txbDni);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cbxLegajos);
            this.Controls.Add(this.lblLegajo);
            this.Name = "FormModificarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModificarPersona";
            this.Load += new System.EventHandler(this.FormModificarPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.ComboBox cbxLegajos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Button btbGuardar;
    }
}