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
            this.SuspendLayout();
            // 
            // lstModificarPersonas
            // 
            this.lstModificarPersonas.FormattingEnabled = true;
            this.lstModificarPersonas.ItemHeight = 20;
            this.lstModificarPersonas.Location = new System.Drawing.Point(16, 32);
            this.lstModificarPersonas.Name = "lstModificarPersonas";
            this.lstModificarPersonas.Size = new System.Drawing.Size(662, 324);
            this.lstModificarPersonas.TabIndex = 0;
            this.lstModificarPersonas.SelectedIndexChanged += new System.EventHandler(this.lstModificarPersonas_SelectedIndexChanged);
            // 
            // lstCambioCredenciales
            // 
            this.lstCambioCredenciales.FormattingEnabled = true;
            this.lstCambioCredenciales.ItemHeight = 20;
            this.lstCambioCredenciales.Location = new System.Drawing.Point(746, 32);
            this.lstCambioCredenciales.Name = "lstCambioCredenciales";
            this.lstCambioCredenciales.Size = new System.Drawing.Size(669, 324);
            this.lstCambioCredenciales.TabIndex = 1;
            this.lstCambioCredenciales.SelectedIndexChanged += new System.EventHandler(this.lstCambioCredenciales_SelectedIndexChanged);
            // 
            // btnAprobarModificacionPersona
            // 
            this.btnAprobarModificacionPersona.Location = new System.Drawing.Point(182, 365);
            this.btnAprobarModificacionPersona.Name = "btnAprobarModificacionPersona";
            this.btnAprobarModificacionPersona.Size = new System.Drawing.Size(137, 62);
            this.btnAprobarModificacionPersona.TabIndex = 2;
            this.btnAprobarModificacionPersona.Text = "Aprobar Modificación";
            this.btnAprobarModificacionPersona.UseVisualStyleBackColor = true;
            this.btnAprobarModificacionPersona.Click += new System.EventHandler(this.btnAprobarModificacionPersona_Click);
            // 
            // btnRechazarModificacionPersona
            // 
            this.btnRechazarModificacionPersona.Location = new System.Drawing.Point(364, 365);
            this.btnRechazarModificacionPersona.Name = "btnRechazarModificacionPersona";
            this.btnRechazarModificacionPersona.Size = new System.Drawing.Size(142, 62);
            this.btnRechazarModificacionPersona.TabIndex = 3;
            this.btnRechazarModificacionPersona.Text = "Rechazar";
            this.btnRechazarModificacionPersona.UseVisualStyleBackColor = true;
            this.btnRechazarModificacionPersona.Click += new System.EventHandler(this.btnRechazarModificacionPersona_Click);
            // 
            // btnActualizarCredencial
            // 
            this.btnActualizarCredencial.Location = new System.Drawing.Point(971, 365);
            this.btnActualizarCredencial.Name = "btnActualizarCredencial";
            this.btnActualizarCredencial.Size = new System.Drawing.Size(122, 62);
            this.btnActualizarCredencial.TabIndex = 4;
            this.btnActualizarCredencial.Text = "Actualizar";
            this.btnActualizarCredencial.UseVisualStyleBackColor = true;
            this.btnActualizarCredencial.Click += new System.EventHandler(this.btnActualizarCredencial_Click);
            // 
            // btnRechazarcred
            // 
            this.btnRechazarcred.Location = new System.Drawing.Point(1110, 365);
            this.btnRechazarcred.Name = "btnRechazarcred";
            this.btnRechazarcred.Size = new System.Drawing.Size(127, 62);
            this.btnRechazarcred.TabIndex = 5;
            this.btnRechazarcred.Text = "Rechazar";
            this.btnRechazarcred.UseVisualStyleBackColor = true;
            this.btnRechazarcred.Click += new System.EventHandler(this.btnRechazarcred_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modificar personas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Actualizar Credenciales";
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRechazarcred);
            this.Controls.Add(this.btnActualizarCredencial);
            this.Controls.Add(this.btnRechazarModificacionPersona);
            this.Controls.Add(this.btnAprobarModificacionPersona);
            this.Controls.Add(this.lstCambioCredenciales);
            this.Controls.Add(this.lstModificarPersonas);
            this.Name = "FormAdministrador";
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
    }
}