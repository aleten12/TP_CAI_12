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
using Datos.Seguridad;
using Persistencia;

namespace TemplateTPCorto
{
    public partial class FormSeleccionPerfil : Form
    {
        private List<Perfil> _perfilesDisponibles;
        public Perfil PerfilSeleccionado { get; private set; }

        public FormSeleccionPerfil(List<Perfil> perfiles)
        {
            InitializeComponent();
            _perfilesDisponibles = perfiles;

            foreach (Perfil perfil in _perfilesDisponibles)
            {
                comboBoxPerfiles.Items.Add(perfil._descripcion);
            }

            if (comboBoxPerfiles.Items.Count > 0)
            {
                comboBoxPerfiles.SelectedIndex = 0;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string descripcionSeleccionada = comboBoxPerfiles.SelectedItem.ToString();

            foreach (var perfil in _perfilesDisponibles)
            {
                if (perfil._descripcion == descripcionSeleccionada)
                {
                    PerfilSeleccionado = perfil;
                    break;
                }
            }

            if (PerfilSeleccionado != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Perfil seleccionado no válido.");
            }
        }

     
    }

}
