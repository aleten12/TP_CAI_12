using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Negocio;
using Persistencia;
using Persistencia.DataBase;

namespace TemplateTPCorto
{
    public partial class FormAdministrador : Form
    {
        private string legajoInicial;

        // Constructor vacío
        public FormAdministrador()
        {
            InitializeComponent();
        }

        // Constructor opcional con legajo
        public FormAdministrador(string legajo)
        {
            InitializeComponent();
            legajoInicial = legajo;
        }
        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            DataBaseUtils dbUtils = new DataBaseUtils();

            CargarCambioCredenciales();
            CargarCambioPersonas();
        }

        private void CargarCambioCredenciales()
        {
            DataBaseUtils dbUtils = new DataBaseUtils();
            List<string> lineas = dbUtils.BuscarDatosPersistencia("operacion_cambio_credencial.csv");

            lstCambioCredenciales.Items.Clear();

            foreach (var linea in lineas)
            {
                lstCambioCredenciales.Items.Add(linea);
            }
        }
        private void CargarCambioPersonas()
        {
            DataBaseUtils dbUtils = new DataBaseUtils();
            List<string> lineas = dbUtils.BuscarDatosPersistencia("operacion_cambio_persona.csv");

            lstModificarPersonas.Items.Clear();

            foreach (var linea in lineas)
            {
                lstModificarPersonas.Items.Add(linea);
            }
        }
        private void lstModificarPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstCambioCredenciales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAprobarModificacionPersona_Click(object sender, EventArgs e)
        {
            if (lstModificarPersonas.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná una modificación para aprobar.");
                return;
            }

            string lineaSeleccionada = lstModificarPersonas.SelectedItem.ToString();
            string[] campos = lineaSeleccionada.Split(';');

            if (campos.Length < 6)
            {
                MessageBox.Show("La línea seleccionada no es válida.");
                return;
            }

            string legajo = campos[1];
            string nombre = campos[2];
            string apellido = campos[3];
            string dni = campos[4];
            string fechaIngreso = campos[5];

            ModificarPersona modificador = new ModificarPersona();
            bool resultado = modificador.GuardarDatosModificados(legajo, nombre, apellido, dni, fechaIngreso);

            if (resultado)
            {
                // Eliminar la línea aprobada del archivo de operaciones
                EliminarLineaOperacion("operacion_cambio_persona.csv", lineaSeleccionada);

                MessageBox.Show("Modificación aprobada y aplicada con éxito.");
                CargarCambioPersonas();
            }
            else
            {
                MessageBox.Show("No se aplicaron cambios.");
            }

        }

        private void btnRechazarModificacionPersona_Click(object sender, EventArgs e)
        {
            if (lstModificarPersonas.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná una modificación para rechazar.");
                return;
            }

            string lineaSeleccionada = lstModificarPersonas.SelectedItem.ToString();

            // Eliminar la línea rechazada
            EliminarLineaOperacion("operacion_cambio_persona.csv", lineaSeleccionada);

            MessageBox.Show("Modificación rechazada correctamente.");
            CargarCambioPersonas();


        }

        private void btnActualizarCredencial_Click(object sender, EventArgs e)
        {
            if (lstCambioCredenciales.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná una modificación de credencial para aprobar.");
                return;
            }

            string lineaSeleccionada = lstCambioCredenciales.SelectedItem.ToString();
            string[] campos = lineaSeleccionada.Split(';');

            if (campos.Length < 6)
            {
                MessageBox.Show("La línea seleccionada no es válida.");
                return;
            }

            string legajo = campos[1];
            string nombreUsuario = campos[2];
            string nuevaContrasena = campos[3];
            string idPerfil = campos[4];
            string fechaAlta = campos[5];

            ModificarCredencial modificador = new ModificarCredencial();
            bool resultado = modificador.CambiarContrasena(legajo, nuevaContrasena);

            if (resultado)
            {
                EliminarLineaOperacion("operacion_cambio_credencial.csv", lineaSeleccionada);

                MessageBox.Show("Credencial modificada y aprobada con éxito.");
                CargarCambioCredenciales();
            }
            else
            {
                MessageBox.Show("No se pudo aplicar la modificación.");
            }

        }

        private void btnRechazarcred_Click(object sender, EventArgs e)
        {
            if (lstCambioCredenciales.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná una modificación de credencial para rechazar.");
                return;
            }

            string lineaSeleccionada = lstCambioCredenciales.SelectedItem.ToString();

            EliminarLineaOperacion("operacion_cambio_credencial.csv", lineaSeleccionada);

            MessageBox.Show("Modificación de credencial rechazada correctamente.");
            CargarCambioCredenciales();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EliminarLineaOperacion(string nombreArchivo, string lineaAEliminar)
        {
            DataBaseUtils dbUtils = new DataBaseUtils();
            List<string> lineas = dbUtils.BuscarDatosPersistencia(nombreArchivo);

            // Reescribimos sin la línea que queremos eliminar
            var nuevasLineas = lineas.Where(l => l != lineaAEliminar).ToList();

            try
            {
                string rutaProyecto = @"C:\Users\Usuario\Documents\TP_CAI_12\TemplateTPCorto";
                string rutaCompleta = Path.Combine(rutaProyecto, "Persistencia", "DataBase", "Tablas", nombreArchivo);

                File.WriteAllLines(rutaCompleta, nuevasLineas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la línea: " + ex.Message);
            }
        }

    }
}
