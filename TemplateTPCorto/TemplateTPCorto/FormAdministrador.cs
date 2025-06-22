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
using Datos;

namespace TemplateTPCorto
{
    public partial class FormAdministrador : Form
    {
        private string legajoInicial;
        private readonly GestorOperaciones gestor = new GestorOperaciones();
        private readonly GestorCambioPersona gestorCambioPersona = new GestorCambioPersona();
        private readonly GestorCambioCredenciales gestorCambioCredenciales = new GestorCambioCredenciales();


        // Constructor vacío
        public FormAdministrador()
        {
            InitializeComponent();
        }
        public FormAdministrador(Credencial credencial)
        {
            InitializeComponent();
            Credencial = credencial;
        }
        public Credencial Credencial { get; }

        private FormAdministradorBienvenida formAnterior;
        public FormAdministrador(FormAdministradorBienvenida admin)
        {
            InitializeComponent();
            formAnterior = admin;
            this.FormClosed += FormAdministrador_FormClosed;
        }

        private void FormAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAnterior.Show();
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
            var cambios = gestor.ObtenerCambioCredenciales();

            lstCambioCredenciales.Items.Clear();

            foreach (var linea in cambios)
            {
                lstCambioCredenciales.Items.Add(linea);
            }
        }

        private void CargarCambioPersonas()
        {
            var cambios = gestor.ObtenerCambioPersonas();

            lstModificarPersonas.Items.Clear();

            foreach (var linea in cambios)
            {
                lstModificarPersonas.Items.Add(linea);
            }
        }

        // Clase auxiliar para guardar línea real + texto visible
        private class ListItem
        {
            public string LineaOriginal { get; }
            private string TextoMostrar { get; }

            public ListItem(string lineaOriginal, string textoMostrar)
            {
                LineaOriginal = lineaOriginal;
                TextoMostrar = textoMostrar;
            }

            public override string ToString()
            {
                return TextoMostrar;
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

            // Usamos el método del gestor en la capa negocio
            bool fueAplicada = gestorCambioPersona.AplicarCambioPersona(lineaSeleccionada);

            if (fueAplicada)
            {
                lstModificarPersonas.Items.Remove(lstModificarPersonas.SelectedItem);
                MessageBox.Show("Modificación aprobada y aplicada con éxito.");
            }
            else
            {
                MessageBox.Show("No se pudo aplicar la modificación. Verificá los datos.");
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

            // Usamos el método del gestor en la capa negocio
            gestorCambioPersona.RechazarCambioPersona(lineaSeleccionada);

            MessageBox.Show("Modificación rechazada correctamente.");
            CargarCambioPersonas();
        }



        private void btnActualizarCredencial_Click(object sender, EventArgs e)
        {
            if (lstCambioCredenciales.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná una modificación para aprobar.");
                return;
            }

            string lineaSeleccionada = lstCambioCredenciales.SelectedItem.ToString();

            bool aplicado = gestorCambioCredenciales.AplicarCambioCredencial(lineaSeleccionada);

            if (aplicado)
            {
                lstCambioCredenciales.Items.Remove(lstCambioCredenciales.SelectedItem);
                MessageBox.Show("Cambio aplicado correctamente.");
            }
            else
            {
                MessageBox.Show("No se pudo aplicar el cambio.");
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

            gestorCambioCredenciales.RechazarCambioCredencial(lineaSeleccionada);

            MessageBox.Show("Modificación de credencial rechazada correctamente.");
            CargarCambioCredenciales();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
