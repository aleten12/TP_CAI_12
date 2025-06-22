namespace TemplateTPCorto
{
    partial class FormOperador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperador));
            this.btnCargarVentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargarVentas
            // 
            this.btnCargarVentas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCargarVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCargarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarVentas.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargarVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarVentas.Image")));
            this.btnCargarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarVentas.Location = new System.Drawing.Point(324, 254);
            this.btnCargarVentas.Name = "btnCargarVentas";
            this.btnCargarVentas.Size = new System.Drawing.Size(346, 72);
            this.btnCargarVentas.TabIndex = 0;
            this.btnCargarVentas.Text = "Cargar Ventas";
            this.btnCargarVentas.UseVisualStyleBackColor = false;
            this.btnCargarVentas.Click += new System.EventHandler(this.btnCargarVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "¡Bienvenido Operador!";
            // 
            // FormOperador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormOperador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOperador";
            this.Load += new System.EventHandler(this.FormOperador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarVentas;
        private System.Windows.Forms.Label label1;
    }
}