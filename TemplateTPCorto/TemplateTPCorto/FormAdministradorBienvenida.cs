using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace TemplateTPCorto
{
    public partial class FormAdministradorBienvenida : Form
    {
        public FormAdministradorBienvenida()
        {
            InitializeComponent();
        }
        public Credencial Credencial { get; }
        public FormAdministradorBienvenida(Credencial credencial)
        {
            InitializeComponent();
            Credencial = credencial;

        }

        private void btbAutorizaciones_Click(object sender, EventArgs e)
        {
            FormAdministrador formAdmin = new FormAdministrador(this);
            formAdmin.Show();
            this.Hide();
        }
    }
}
