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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            this.lstModificarPersonas = new System.Windows.Forms.ListBox();
            this.lstCambioCredenciales = new System.Windows.Forms.ListBox();
            this.btnAprobarModificacionPersona = new System.Windows.Forms.Button();
            this.btnRechazarModificacionPersona = new System.Windows.Forms.Button();
            this.btnActualizarCredencial = new System.Windows.Forms.Button();
            this.btnRechazarcred = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambiarContraseña_Click = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lstModificarPersonas
            // 
            this.lstModificarPersonas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstModificarPersonas.FormattingEnabled = true;
            this.lstModificarPersonas.ItemHeight = 21;
            this.lstModificarPersonas.Location = new System.Drawing.Point(32, 106);
            this.lstModificarPersonas.Name = "lstModificarPersonas";
            this.lstModificarPersonas.Size = new System.Drawing.Size(708, 277);
            this.lstModificarPersonas.TabIndex = 0;
            this.lstModificarPersonas.SelectedIndexChanged += new System.EventHandler(this.lstModificarPersonas_SelectedIndexChanged);
            // 
            // lstCambioCredenciales
            // 
            this.lstCambioCredenciales.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCambioCredenciales.FormattingEnabled = true;
            this.lstCambioCredenciales.ItemHeight = 21;
            this.lstCambioCredenciales.Location = new System.Drawing.Point(32, 454);
            this.lstCambioCredenciales.Name = "lstCambioCredenciales";
            this.lstCambioCredenciales.Size = new System.Drawing.Size(708, 277);
            this.lstCambioCredenciales.TabIndex = 1;
            this.lstCambioCredenciales.SelectedIndexChanged += new System.EventHandler(this.lstCambioCredenciales_SelectedIndexChanged);
            // 
            // btnAprobarModificacionPersona
            // 
            this.btnAprobarModificacionPersona.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAprobarModificacionPersona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAprobarModificacionPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprobarModificacionPersona.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobarModificacionPersona.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAprobarModificacionPersona.Location = new System.Drawing.Point(768, 106);
            this.btnAprobarModificacionPersona.Name = "btnAprobarModificacionPersona";
            this.btnAprobarModificacionPersona.Size = new System.Drawing.Size(234, 62);
            this.btnAprobarModificacionPersona.TabIndex = 2;
            this.btnAprobarModificacionPersona.Text = "Aprobar Modificación";
            this.btnAprobarModificacionPersona.UseVisualStyleBackColor = false;
            this.btnAprobarModificacionPersona.Click += new System.EventHandler(this.btnAprobarModificacionPersona_Click);
            // 
            // btnRechazarModificacionPersona
            // 
            this.btnRechazarModificacionPersona.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRechazarModificacionPersona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRechazarModificacionPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazarModificacionPersona.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarModificacionPersona.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRechazarModificacionPersona.Location = new System.Drawing.Point(768, 199);
            this.btnRechazarModificacionPersona.Name = "btnRechazarModificacionPersona";
            this.btnRechazarModificacionPersona.Size = new System.Drawing.Size(234, 62);
            this.btnRechazarModificacionPersona.TabIndex = 3;
            this.btnRechazarModificacionPersona.Text = "Rechazar";
            this.btnRechazarModificacionPersona.UseVisualStyleBackColor = false;
            this.btnRechazarModificacionPersona.Click += new System.EventHandler(this.btnRechazarModificacionPersona_Click);
            // 
            // btnActualizarCredencial
            // 
            this.btnActualizarCredencial.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnActualizarCredencial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnActualizarCredencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCredencial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCredencial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarCredencial.Location = new System.Drawing.Point(771, 453);
            this.btnActualizarCredencial.Name = "btnActualizarCredencial";
            this.btnActualizarCredencial.Size = new System.Drawing.Size(231, 62);
            this.btnActualizarCredencial.TabIndex = 4;
            this.btnActualizarCredencial.Text = "Actualizar Credencial";
            this.btnActualizarCredencial.UseVisualStyleBackColor = false;
            this.btnActualizarCredencial.Click += new System.EventHandler(this.btnActualizarCredencial_Click);
            // 
            // btnRechazarcred
            // 
            this.btnRechazarcred.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRechazarcred.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRechazarcred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazarcred.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarcred.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRechazarcred.Location = new System.Drawing.Point(771, 553);
            this.btnRechazarcred.Name = "btnRechazarcred";
            this.btnRechazarcred.Size = new System.Drawing.Size(231, 62);
            this.btnRechazarcred.TabIndex = 5;
            this.btnRechazarcred.Text = "Rechazar";
            this.btnRechazarcred.UseVisualStyleBackColor = false;
            this.btnRechazarcred.Click += new System.EventHandler(this.btnRechazarcred_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modificar Personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Actualizar Credenciales";
            // 
            // btnCambiarContraseña_Click
            // 
            this.btnCambiarContraseña_Click.Location = new System.Drawing.Point(771, 667);
            this.btnCambiarContraseña_Click.Name = "btnCambiarContraseña_Click";
            this.btnCambiarContraseña_Click.Size = new System.Drawing.Size(139, 62);
            this.btnCambiarContraseña_Click.TabIndex = 8;
            this.btnCambiarContraseña_Click.Text = "Cambiar contraseña";
            this.btnCambiarContraseña_Click.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña_Click.Click += new System.EventHandler(this.btnCambiarContraseña_Click_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1028, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1070, 820);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCambiarContraseña_Click);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRechazarcred);
            this.Controls.Add(this.btnActualizarCredencial);
            this.Controls.Add(this.btnRechazarModificacionPersona);
            this.Controls.Add(this.btnAprobarModificacionPersona);
            this.Controls.Add(this.lstCambioCredenciales);
            this.Controls.Add(this.lstModificarPersonas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdministrador";
            this.Load += new System.EventHandler(this.FormAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
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
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}