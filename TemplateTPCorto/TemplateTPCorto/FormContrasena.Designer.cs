﻿namespace TemplateTPCorto
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
            this.txtContrasenaNueva = new System.Windows.Forms.TextBox();
            this.btbActualizarContraseña = new System.Windows.Forms.Button();
            this.lblContraseñaActual = new System.Windows.Forms.Label();
            this.txtContrasenaActual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(271, 200);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(194, 25);
            this.lblContraseña.TabIndex = 0;
            this.lblContraseña.Text = "Contraseña nueva ";
            // 
            // txtContrasenaNueva
            // 
            this.txtContrasenaNueva.Location = new System.Drawing.Point(276, 244);
            this.txtContrasenaNueva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrasenaNueva.Name = "txtContrasenaNueva";
            this.txtContrasenaNueva.Size = new System.Drawing.Size(360, 31);
            this.txtContrasenaNueva.TabIndex = 1;
            // 
            // btbActualizarContraseña
            // 
            this.btbActualizarContraseña.Location = new System.Drawing.Point(276, 325);
            this.btbActualizarContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btbActualizarContraseña.Name = "btbActualizarContraseña";
            this.btbActualizarContraseña.Size = new System.Drawing.Size(361, 49);
            this.btbActualizarContraseña.TabIndex = 2;
            this.btbActualizarContraseña.Text = "Actualizar Contraseña";
            this.btbActualizarContraseña.UseVisualStyleBackColor = true;
            this.btbActualizarContraseña.Click += new System.EventHandler(this.btbActualizarContraseña_Click);
            // 
            // lblContraseñaActual
            // 
            this.lblContraseñaActual.AutoSize = true;
            this.lblContraseñaActual.Location = new System.Drawing.Point(271, 98);
            this.lblContraseñaActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseñaActual.Name = "lblContraseñaActual";
            this.lblContraseñaActual.Size = new System.Drawing.Size(187, 25);
            this.lblContraseñaActual.TabIndex = 3;
            this.lblContraseñaActual.Text = "Contraseña actual";
            // 
            // txtContrasenaActual
            // 
            this.txtContrasenaActual.Location = new System.Drawing.Point(276, 144);
            this.txtContrasenaActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContrasenaActual.Name = "txtContrasenaActual";
            this.txtContrasenaActual.Size = new System.Drawing.Size(360, 31);
            this.txtContrasenaActual.TabIndex = 4;
            // 
            // FormContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 518);
            this.Controls.Add(this.txtContrasenaActual);
            this.Controls.Add(this.lblContraseñaActual);
            this.Controls.Add(this.btbActualizarContraseña);
            this.Controls.Add(this.txtContrasenaNueva);
            this.Controls.Add(this.lblContraseña);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContrasenaNueva;
        private System.Windows.Forms.Button btbActualizarContraseña;
        private System.Windows.Forms.Label lblContraseñaActual;
        private System.Windows.Forms.TextBox txtContrasenaActual;
    }
}