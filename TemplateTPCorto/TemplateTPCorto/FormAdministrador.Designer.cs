namespace TemplateTPCorto
{
    partial class FormAdministrador
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
            this.lstModificarPersonas = new System.Windows.Forms.ListBox();
            this.lstCambioCredenciales = new System.Windows.Forms.ListBox();
            this.btnAprobarModificacionPersona = new System.Windows.Forms.Button();
            this.btnRechazarModificacionPersona = new System.Windows.Forms.Button();
            this.btnActualizarCredencial = new System.Windows.Forms.Button();
            this.btnRechazarcred = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambiarContraseña_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstModificarPersonas
            // 
            this.lstModificarPersonas.FormattingEnabled = true;
            this.lstModificarPersonas.ItemHeight = 25;
            this.lstModificarPersonas.Location = new System.Drawing.Point(23, 69);
            this.lstModificarPersonas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstModificarPersonas.Name = "lstModificarPersonas";
            this.lstModificarPersonas.Size = new System.Drawing.Size(832, 404);
            this.lstModificarPersonas.TabIndex = 0;
            this.lstModificarPersonas.SelectedIndexChanged += new System.EventHandler(this.lstModificarPersonas_SelectedIndexChanged);
            // 
            // lstCambioCredenciales
            // 
            this.lstCambioCredenciales.FormattingEnabled = true;
            this.lstCambioCredenciales.ItemHeight = 25;
            this.lstCambioCredenciales.Location = new System.Drawing.Point(887, 69);
            this.lstCambioCredenciales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCambioCredenciales.Name = "lstCambioCredenciales";
            this.lstCambioCredenciales.Size = new System.Drawing.Size(819, 404);
            this.lstCambioCredenciales.TabIndex = 1;
            this.lstCambioCredenciales.SelectedIndexChanged += new System.EventHandler(this.lstCambioCredenciales_SelectedIndexChanged);
            // 
            // btnAprobarModificacionPersona
            // 
            this.btnAprobarModificacionPersona.Location = new System.Drawing.Point(215, 485);
            this.btnAprobarModificacionPersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAprobarModificacionPersona.Name = "btnAprobarModificacionPersona";
            this.btnAprobarModificacionPersona.Size = new System.Drawing.Size(183, 78);
            this.btnAprobarModificacionPersona.TabIndex = 2;
            this.btnAprobarModificacionPersona.Text = "Aprobar Modificación";
            this.btnAprobarModificacionPersona.UseVisualStyleBackColor = true;
            this.btnAprobarModificacionPersona.Click += new System.EventHandler(this.btnAprobarModificacionPersona_Click);
            // 
            // btnRechazarModificacionPersona
            // 
            this.btnRechazarModificacionPersona.Location = new System.Drawing.Point(457, 485);
            this.btnRechazarModificacionPersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRechazarModificacionPersona.Name = "btnRechazarModificacionPersona";
            this.btnRechazarModificacionPersona.Size = new System.Drawing.Size(189, 78);
            this.btnRechazarModificacionPersona.TabIndex = 3;
            this.btnRechazarModificacionPersona.Text = "Rechazar";
            this.btnRechazarModificacionPersona.UseVisualStyleBackColor = true;
            this.btnRechazarModificacionPersona.Click += new System.EventHandler(this.btnRechazarModificacionPersona_Click);
            // 
            // btnActualizarCredencial
            // 
            this.btnActualizarCredencial.Location = new System.Drawing.Point(1096, 485);
            this.btnActualizarCredencial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarCredencial.Name = "btnActualizarCredencial";
            this.btnActualizarCredencial.Size = new System.Drawing.Size(185, 78);
            this.btnActualizarCredencial.TabIndex = 4;
            this.btnActualizarCredencial.Text = "Actualizar";
            this.btnActualizarCredencial.UseVisualStyleBackColor = true;
            this.btnActualizarCredencial.Click += new System.EventHandler(this.btnActualizarCredencial_Click);
            // 
            // btnRechazarcred
            // 
            this.btnRechazarcred.Location = new System.Drawing.Point(1335, 485);
            this.btnRechazarcred.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRechazarcred.Name = "btnRechazarcred";
            this.btnRechazarcred.Size = new System.Drawing.Size(173, 78);
            this.btnRechazarcred.TabIndex = 5;
            this.btnRechazarcred.Text = "Rechazar";
            this.btnRechazarcred.UseVisualStyleBackColor = true;
            this.btnRechazarcred.Click += new System.EventHandler(this.btnRechazarcred_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modificar Personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(881, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Actualizar Credenciales";
            // 
            // btnCambiarContraseña_Click
            // 
            this.btnCambiarContraseña_Click.Location = new System.Drawing.Point(786, 485);
            this.btnCambiarContraseña_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnCambiarContraseña_Click.Name = "btnCambiarContraseña_Click";
            this.btnCambiarContraseña_Click.Size = new System.Drawing.Size(198, 78);
            this.btnCambiarContraseña_Click.TabIndex = 8;
            this.btnCambiarContraseña_Click.Text = "Cambiar contraseña";
            this.btnCambiarContraseña_Click.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña_Click.Click += new System.EventHandler(this.btnCambiarContraseña_Click_Click);
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1765, 624);
            this.Controls.Add(this.btnCambiarContraseña_Click);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRechazarcred);
            this.Controls.Add(this.btnActualizarCredencial);
            this.Controls.Add(this.btnRechazarModificacionPersona);
            this.Controls.Add(this.btnAprobarModificacionPersona);
            this.Controls.Add(this.lstCambioCredenciales);
            this.Controls.Add(this.lstModificarPersonas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdministrador";
            this.Load += new System.EventHandler(this.FormAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstModificarPersonas;
        private System.Windows.Forms.ListBox lstCambioCredenciales;
        private System.Windows.Forms.Button btnAprobarModificacionPersona;
        private System.Windows.Forms.Button btnRechazarModificacionPersona;
        private System.Windows.Forms.Button btnActualizarCredencial;
        private System.Windows.Forms.Button btnRechazarcred;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCambiarContraseña_Click;
    }
}