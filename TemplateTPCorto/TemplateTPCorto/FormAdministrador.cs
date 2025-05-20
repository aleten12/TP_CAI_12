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

            bool primeraLinea = true;
            foreach (var linea in lineas)
            {
                if (primeraLinea)
                {
                    primeraLinea = false;  // Saltar la cabecera
                    continue;
                }

                string[] campos = linea.Split(';');

                if (campos.Length >= 6)
                {
                    string perfil = campos[4];

                    // Validar si perfil es una fecha (error en CSV)
                    DateTime tempDate;
                    if (DateTime.TryParse(perfil, out tempDate))
                    {
                        perfil = "Perfil inválido";
                    }

                    string mostrar = $"Legajo: {campos[1]}, Usuario: {campos[2]}, Contraseña: {campos[3]}, Perfil: {campos[4]}, Fecha Alta: {campos[5]}";


                    lstCambioCredenciales.Items.Add(new ListItem(linea, mostrar));
                }
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



        private void CargarCambioPersonas()
        {
            DataBaseUtils dbUtils = new DataBaseUtils();
            List<string> lineas = dbUtils.BuscarDatosPersistencia("operacion_cambio_persona.csv");

            lstModificarPersonas.Items.Clear();

            // Saltear la primera línea (índice 0) que es el encabezado
            for (int i = 1; i < lineas.Count; i++)
            {
                lstModificarPersonas.Items.Add(lineas[i]);
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

                // Quitar el ítem de la lista sin recargar todo
                lstModificarPersonas.Items.Remove(lstModificarPersonas.SelectedItem);

                MessageBox.Show("Modificación aprobada y aplicada con éxito.");
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

            ListItem itemSeleccionado = (ListItem)lstCambioCredenciales.SelectedItem;
            string lineaSeleccionada = itemSeleccionado.LineaOriginal;
            string[] campos = lineaSeleccionada.Split(';');

            if (campos.Length < 6)
            {
                MessageBox.Show("La línea seleccionada no es válida.");
                return;
            }

            string legajo = campos[1];
            string nuevaContrasena = campos[3];

            ModificarCredencial modificador = new ModificarCredencial();
            bool resultado = modificador.CambiarContrasena(legajo, nuevaContrasena);

            if (resultado)
            {
                EliminarLineaOperacion("operacion_cambio_credencial.csv", lineaSeleccionada);

                // Quitar el ítem aprobado del ListBox
                lstCambioCredenciales.Items.Remove(itemSeleccionado);

                MessageBox.Show("Credencial modificada y aprobada con éxito.");
                // O bien recargar todo:
                // CargarCambioCredenciales();
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

            string lineaSeleccionada = ((ListItem)lstCambioCredenciales.SelectedItem).LineaOriginal;


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

            string idOperacionEliminar = lineaAEliminar.Split(';')[0].Trim();

            Console.WriteLine($"Buscando eliminar idOperacion: {idOperacionEliminar}");
            Console.WriteLine($"Archivo a modificar: {nombreArchivo}");
            Console.WriteLine($"Líneas totales: {lineas.Count}");

            foreach (var l in lineas)
            {
                var idOp = l.Split(';')[0].Trim();
                Console.WriteLine($"idOperacion archivo: {idOp}");
            }

            var nuevasLineas = lineas.Where(l =>
            {
                if (string.IsNullOrWhiteSpace(l)) return false;
                string idOperacionActual = l.Split(';')[0].Trim();
                return idOperacionActual != idOperacionEliminar;
            }).ToList();

            Console.WriteLine($"Líneas después de filtro: {nuevasLineas.Count}");

            try
            {
                dbUtils.SobrescribirArchivo(nombreArchivo, nuevasLineas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la línea: " + ex.Message);
            }
        }




    }
}
