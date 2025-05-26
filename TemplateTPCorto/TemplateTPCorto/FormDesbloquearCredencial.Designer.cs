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
            this.lblNuevaContrasena = new System.Windows.Forms.Label();
            this.txbContrasena = new System.Windows.Forms.TextBox();
            this.cbxLegajos = new System.Windows.Forms.ComboBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.btbModificarContrasena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevaContrasena
            // 
            this.lblNuevaContrasena.AutoSize = true;
            this.lblNuevaContrasena.Location = new System.Drawing.Point(175, 200);
            this.lblNuevaContrasena.Name = "lblNuevaContrasena";
            this.lblNuevaContrasena.Size = new System.Drawing.Size(138, 20);
            this.lblNuevaContrasena.TabIndex = 0;
            this.lblNuevaContrasena.Text = "Nueva contraseña";
            // 
            // txbContrasena
            // 
            this.txbContrasena.Location = new System.Drawing.Point(347, 194);
            this.txbContrasena.Name = "txbContrasena";
            this.txbContrasena.Size = new System.Drawing.Size(190, 26);
            this.txbContrasena.TabIndex = 1;
            // 
            // cbxLegajos
            // 
            this.cbxLegajos.FormattingEnabled = true;
            this.cbxLegajos.Location = new System.Drawing.Point(347, 137);
            this.cbxLegajos.Name = "cbxLegajos";
            this.cbxLegajos.Size = new System.Drawing.Size(190, 28);
            this.cbxLegajos.TabIndex = 2;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(175, 137);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(57, 20);
            this.lblLegajo.TabIndex = 3;
            this.lblLegajo.Text = "Legajo";
            // 
            // btbModificarContrasena
            // 
            this.btbModificarContrasena.Location = new System.Drawing.Point(267, 263);
            this.btbModificarContrasena.Name = "btbModificarContrasena";
            this.btbModificarContrasena.Size = new System.Drawing.Size(162, 34);
            this.btbModificarContrasena.TabIndex = 4;
            this.btbModificarContrasena.Text = "Modificar";
            this.btbModificarContrasena.UseVisualStyleBackColor = true;
            this.btbModificarContrasena.Click += new System.EventHandler(this.btbModificarContrasena_Click);
            // 
            // FormDesbloquearCredencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 434);
            this.Controls.Add(this.btbModificarContrasena);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.cbxLegajos);
            this.Controls.Add(this.txbContrasena);
            this.Controls.Add(this.lblNuevaContrasena);
            this.Name = "FormDesbloquearCredencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDesbloquearCredencial";
            this.Load += new System.EventHandler(this.FormDesbloquearCredencial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaContrasena;
        private System.Windows.Forms.TextBox txbContrasena;
        private System.Windows.Forms.ComboBox cbxLegajos;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Button btbModificarContrasena;
    }
}