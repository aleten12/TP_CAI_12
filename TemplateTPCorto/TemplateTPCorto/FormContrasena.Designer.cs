namespace TemplateTPCorto
{
    partial class FormContrasena
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
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btbActualizarContraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(212, 159);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(143, 20);
            this.lblContraseña.TabIndex = 0;
            this.lblContraseña.Text = "Contraseña nueva ";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(375, 156);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(175, 26);
            this.txtContraseña.TabIndex = 1;
            // 
            // btbActualizarContraseña
            // 
            this.btbActualizarContraseña.Location = new System.Drawing.Point(240, 226);
            this.btbActualizarContraseña.Name = "btbActualizarContraseña";
            this.btbActualizarContraseña.Size = new System.Drawing.Size(271, 39);
            this.btbActualizarContraseña.TabIndex = 2;
            this.btbActualizarContraseña.Text = "Actualizar Contraseña";
            this.btbActualizarContraseña.UseVisualStyleBackColor = true;
            // 
            // FormContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbActualizarContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Name = "FormContraseña";
            this.Text = "FormContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btbActualizarContraseña;
    }
}