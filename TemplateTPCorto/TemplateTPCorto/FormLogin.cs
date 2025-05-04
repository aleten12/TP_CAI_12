using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPCorto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;

            if (password.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                return; 
            }

            LoginNegocio loginNegocio = new LoginNegocio();
            Credencial credencial = loginNegocio.login(usuario, password);

            if (credencial != null)
            {
                MessageBox.Show("El usuario es válido.");
            }

            if (credencial == null)
            {
                MessageBox.Show("El usuario es inválido.");
            }

        }

       
    }
}
