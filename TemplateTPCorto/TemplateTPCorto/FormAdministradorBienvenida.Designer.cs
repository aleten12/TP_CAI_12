namespace TemplateTPCorto
{
    partial class FormAdministradorBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministradorBienvenida));
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btbAutorizaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(276, 118);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(432, 38);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "¡Bienvenido Administrador!";
            // 
            // btbAutorizaciones
            // 
            this.btbAutorizaciones.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btbAutorizaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btbAutorizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbAutorizaciones.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbAutorizaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btbAutorizaciones.Image = ((System.Drawing.Image)(resources.GetObject("btbAutorizaciones.Image")));
            this.btbAutorizaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbAutorizaciones.Location = new System.Drawing.Point(283, 227);
            this.btbAutorizaciones.Name = "btbAutorizaciones";
            this.btbAutorizaciones.Size = new System.Drawing.Size(413, 59);
            this.btbAutorizaciones.TabIndex = 1;
            this.btbAutorizaciones.Text = "Autorizaciones";
            this.btbAutorizaciones.UseVisualStyleBackColor = false;
            this.btbAutorizaciones.Click += new System.EventHandler(this.btbAutorizaciones_Click);
            // 
            // FormAdministradoBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1028, 544);
            this.Controls.Add(this.btbAutorizaciones);
            this.Controls.Add(this.lblAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdministradoBienvenida";
            this.Text = "FormAdministradoBienvenida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btbAutorizaciones;
    }
}