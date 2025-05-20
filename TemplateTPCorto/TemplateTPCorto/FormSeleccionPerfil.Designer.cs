namespace TemplateTPCorto
{
    partial class FormSeleccionPerfil
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
            this.comboBoxPerfiles = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPerfiles
            // 
            this.comboBoxPerfiles.FormattingEnabled = true;
            this.comboBoxPerfiles.Location = new System.Drawing.Point(115, 79);
            this.comboBoxPerfiles.Name = "comboBoxPerfiles";
            this.comboBoxPerfiles.Size = new System.Drawing.Size(151, 21);
            this.comboBoxPerfiles.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(120, 173);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(145, 26);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FormSeleccionPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 301);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.comboBoxPerfiles);
            this.Name = "FormSeleccionPerfil";
            this.Text = "FormSeleccionPerfil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPerfiles;
        private System.Windows.Forms.Button btnAceptar;
    }
}