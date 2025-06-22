namespace TemplateTPCorto
{
    partial class FormDesbloquearCredencial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesbloquearCredencial));
            this.lblNuevaContrasena = new System.Windows.Forms.Label();
            this.txbContrasena = new System.Windows.Forms.TextBox();
            this.cbxLegajos = new System.Windows.Forms.ComboBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.btbModificarContrasena = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevaContrasena
            // 
            this.lblNuevaContrasena.AutoSize = true;
            this.lblNuevaContrasena.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContrasena.Location = new System.Drawing.Point(233, 263);
            this.lblNuevaContrasena.Name = "lblNuevaContrasena";
            this.lblNuevaContrasena.Size = new System.Drawing.Size(211, 25);
            this.lblNuevaContrasena.TabIndex = 0;
            this.lblNuevaContrasena.Text = "Nueva contraseña";
            // 
            // txbContrasena
            // 
            this.txbContrasena.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContrasena.Location = new System.Drawing.Point(475, 258);
            this.txbContrasena.Name = "txbContrasena";
            this.txbContrasena.Size = new System.Drawing.Size(190, 34);
            this.txbContrasena.TabIndex = 1;
            // 
            // cbxLegajos
            // 
            this.cbxLegajos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLegajos.FormattingEnabled = true;
            this.cbxLegajos.Location = new System.Drawing.Point(405, 176);
            this.cbxLegajos.Name = "cbxLegajos";
            this.cbxLegajos.Size = new System.Drawing.Size(260, 33);
            this.cbxLegajos.TabIndex = 2;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(233, 176);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(91, 28);
            this.lblLegajo.TabIndex = 3;
            this.lblLegajo.Text = "Legajo";
            // 
            // btbModificarContrasena
            // 
            this.btbModificarContrasena.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btbModificarContrasena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btbModificarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbModificarContrasena.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbModificarContrasena.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btbModificarContrasena.Location = new System.Drawing.Point(301, 346);
            this.btbModificarContrasena.Name = "btbModificarContrasena";
            this.btbModificarContrasena.Size = new System.Drawing.Size(286, 54);
            this.btbModificarContrasena.TabIndex = 4;
            this.btbModificarContrasena.Text = "Modificar Contraseña";
            this.btbModificarContrasena.UseVisualStyleBackColor = false;
            this.btbModificarContrasena.Click += new System.EventHandler(this.btbModificarContrasena_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(877, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormDesbloquearCredencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(919, 537);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btbModificarContrasena);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.cbxLegajos);
            this.Controls.Add(this.txbContrasena);
            this.Controls.Add(this.lblNuevaContrasena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDesbloquearCredencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDesbloquearCredencial";
            this.Load += new System.EventHandler(this.FormDesbloquearCredencial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaContrasena;
        private System.Windows.Forms.TextBox txbContrasena;
        private System.Windows.Forms.ComboBox cbxLegajos;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Button btbModificarContrasena;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}