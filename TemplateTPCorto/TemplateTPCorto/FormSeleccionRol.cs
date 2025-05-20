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
    public partial class FormSeleccionRol : Form
    {
        private List<Rol> _rolesDisponibles;
        public Rol RolSeleccionado { get; private set; }
        public FormSeleccionRol(List<Rol> roles)
        {
            InitializeComponent();
            _rolesDisponibles = roles;

            foreach (Rol rol in roles)
            {
                comboBoxRoles.Items.Add(rol._descripcion);
            }

            comboBoxRoles.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string descripcionSeleccionada = comboBoxRoles.SelectedItem.ToString();

            RolSeleccionado = null;
            foreach (Rol rol in _rolesDisponibles)
            {
                if (rol._descripcion == descripcionSeleccionada)
                {
                    RolSeleccionado = rol;
                    break;
                }
            }

            if (RolSeleccionado != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Rol seleccionado no válido.");
            }
        }


    }
}
