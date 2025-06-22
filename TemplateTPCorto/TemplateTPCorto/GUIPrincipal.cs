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
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
        }
        
        public Credencial Credencial { get; set; }
        public void CargarFormularioSegunPerfil(Credencial credencial, string descripcionPerfil)
        {
            Form formPerfil;

            switch (descripcionPerfil)
            {
                case "Supervisor":
                    formPerfil = new FormSupervisor(credencial);
                    break;
                case "Administrador":
                    formPerfil = new FormAdministradorBienvenida(credencial);
                    break;
                case "Operador":
                    formPerfil = new FormOperador(credencial);
                    break;
                default:
                    MessageBox.Show("Perfil desconocido: " + descripcionPerfil);
                    return;
            }

            AbrirFormInPanel(formPerfil);
        }
        public void AbrirFormInPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        public void MostrarNombreUsuario(string nombre)
        {
            lblUsuario.Text = $"¡Hola,\n{nombre}!";
            lblUsuario.Visible = true;
            btbCambiarContrasena.Visible = true;
            pictureBox1.Visible = true;
        }

        private void btbIngresar_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            AbrirFormInPanel(new FormLogin(this));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CrearLabelBienvenida()
        {
            Label lblBienvenido = new Label();
            lblBienvenido.Text = "¡Bienvenido a Electro Hogar!";
            lblBienvenido.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            lblBienvenido.TextAlign = ContentAlignment.MiddleCenter;
            lblBienvenido.Dock = DockStyle.Top;
            lblBienvenido.Height = 100;  // altura mayor para evitar corte
            lblBienvenido.Margin = new Padding(0, 90, 0, 10); // espacio arriba y abajo
            lblBienvenido.AutoSize = false;
            panelContenedor.Controls.Add(lblBienvenido);
        }

        private void CrearLabelLeyenda()
        {
            Label lblLeyenda = new Label();
            lblLeyenda.Text = "Pulse Ingresar para continuar.";
            lblLeyenda.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            lblLeyenda.TextAlign = ContentAlignment.MiddleCenter;
            lblLeyenda.Dock = DockStyle.Top;
            lblLeyenda.Height = 50;
            lblLeyenda.Margin = new Padding(0, 0, 0, 20); // espacio debajo
            lblLeyenda.AutoSize = false;
            panelContenedor.Controls.Add(lblLeyenda);
        }
        
        private void btbCerrar_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear(); // Borra todo lo que haya
            CrearLabelLeyenda();
            CrearLabelBienvenida();
            lblUsuario.Visible = false;
            btbCambiarContrasena.Visible = false;
            pictureBox1.Visible = false;
        }

        private void btbCambiarContrasena_Click(object sender, EventArgs e)
        {
            if (Credencial == null)
            {
                MessageBox.Show("No hay un usuario autenticado.");
                return;
            }

            FormContrasena formContrasena = new FormContrasena(Credencial, this);
            formContrasena.Show();
        }
    }
}
