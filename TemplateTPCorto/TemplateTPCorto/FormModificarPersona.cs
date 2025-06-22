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
    public partial class FormModificarPersona : Form
    {
        public FormModificarPersona()
        {
            InitializeComponent();
        }

        private FormSupervisor formAnterior;
        public FormModificarPersona(FormSupervisor supervisor)
        {
            InitializeComponent();
            formAnterior = supervisor;
            this.FormClosed += FormModificarPersona_FormClosed;
        }

        private void FormModificarPersona_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAnterior.Show(); 
        }

        private void btbGuardar_Click(object sender, EventArgs e)
        {
            if (cbxLegajos.SelectedItem == null)
            {
                MessageBox.Show("Se debe seleccionar un legajo.");
                return;
            }

            DateTime fecha;
            if (DateTime.TryParse(txbFechaIngreso.Text, out fecha))
            {
                string fechaFormateada = fecha.ToString("d/M/yyyy");
                
            }
            else
            {
                MessageBox.Show("La fecha ingresada no tiene un formato válido.");
            }


            string legajo = cbxLegajos.SelectedItem.ToString();
            string nombre = txbNombre.Text.Trim();
            string apellido = txbApellido.Text.Trim();
            string dni = txbDni.Text.Trim();
            string fechaIngreso = fecha.ToString("d/M/yyyy");

            ModificarPersona mp = new ModificarPersona();
            mp.RegistrarLinea(legajo, nombre, apellido, dni, fechaIngreso);
            MessageBox.Show("La modificación fue registrada para su aprobación.");
        }

        private void FormModificarPersona_Load(object sender, EventArgs e)
        {
            ModificarPersona mp = new ModificarPersona();
            List<string> listaLegajos = mp.ListarLegajos();

            foreach (string legajo in listaLegajos)
            {
                cbxLegajos.Items.Add(legajo);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
