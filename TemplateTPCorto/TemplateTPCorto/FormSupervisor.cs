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
    public partial class FormSupervisor : Form
    {
        public FormSupervisor()
        {
            InitializeComponent();
        }

        public FormSupervisor(Credencial credencial)
        {
            InitializeComponent();
            Credencial = credencial;
        }
        public Credencial Credencial { get; }

        private void button1_Click(object sender, EventArgs e)
        {
            FormModificarPersona formModificarPersona = new FormModificarPersona();
            formModificarPersona.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDesbloquearCredencial formDesbloquearCredencial = new FormDesbloquearCredencial();
            formDesbloquearCredencial.Show();
            this.Hide();
        }

        private void FormSupervisor_Load(object sender, EventArgs e)
        {

        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            FormContrasena formContrasena = new FormContrasena();
            formContrasena.UsuarioAutenticado = Credencial;
            formContrasena.Show();
            this.Hide();
            return;
        }
    }
}
