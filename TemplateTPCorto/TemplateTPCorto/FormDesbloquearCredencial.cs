using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace TemplateTPCorto
{
    public partial class FormDesbloquearCredencial : Form
    {
        public FormDesbloquearCredencial()
        {
            InitializeComponent();
        }

        private void btbModificarContrasena_Click(object sender, EventArgs e)
        {
            string legajo = cbxLegajos.SelectedItem.ToString();
            string nuevaContrasena = txbContrasena.Text.Trim();

            if (string.IsNullOrWhiteSpace(legajo) || string.IsNullOrWhiteSpace(nuevaContrasena))
            {
                MessageBox.Show("Seleccioná un legajo y escribí una nueva contraseña.");
                return;
            }

            ModificarCredencial negocio = new ModificarCredencial();

            if (negocio.CambiarContrasena(legajo, nuevaContrasena))
            {
                MessageBox.Show("Contraseña modificada correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo modificar la contraseña.");
            }
        }

        private void FormDesbloquearCredencial_Load(object sender, EventArgs e)
        {
            ModificarPersona mp = new ModificarPersona();
            List<string> listaLegajos = mp.ListarLegajos();

            foreach (string legajo in listaLegajos)
            {
                cbxLegajos.Items.Add(legajo);
            }
        }
    }
}
