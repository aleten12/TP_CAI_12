using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Datos.Login;
using Microsoft.Win32;
using Persistencia.DataBase;

namespace Negocio
{
    public class ModificarPersona
    {
        public List<string> ListarLegajos()
        {
            DataBaseUtils db = new DataBaseUtils();
            List<string> lista = db.BuscarRegistro("credenciales.csv");
            List<string> listaLegajos = new List<string>();

            foreach (string registro in lista.Skip(1))
            {
                string[] campos = registro.Split(';');
                string legajo = campos[0];

                listaLegajos.Add(legajo);
            }

            return listaLegajos;
        }

        //USADO POR ADMINISTRADOR
        public bool AplicarCambios(string lineaSeleccionada)
        {
            string[] campos = lineaSeleccionada.Split(';');

            string legajo = campos[1];
            string nombre = campos[2];
            string apellido = campos[3];
            string dni = campos[4];
            string fechaIngreso = campos[5];

            if (legajo == null)
            {
                return false;
            }

            DataBaseUtils db = new DataBaseUtils();
            List<string> registros = db.BuscarRegistro("persona.csv");
            bool actualizado = false;

            for (int i = 1; i < registros.Count; i++)
            {
                string[] camposr = registros[i].Split(';');

                if (camposr[0] == legajo)
                {
                    bool realizoCambio = false;

                    if (!string.IsNullOrWhiteSpace(nombre) && camposr[1] != nombre)
                    {
                        camposr[1] = nombre;
                        realizoCambio = true;
                    }

                    if (!string.IsNullOrWhiteSpace(apellido) && camposr[2] != apellido)
                    {
                        camposr[2] = apellido;
                        realizoCambio = true;
                    }

                    if (!string.IsNullOrWhiteSpace(dni) && camposr[3] != dni)
                    {
                        camposr[3] = dni;
                        realizoCambio = true;
                    }


                    if (!string.IsNullOrWhiteSpace(fechaIngreso) && camposr[4] != fechaIngreso)
                    {
                        camposr[4] = fechaIngreso;
                        realizoCambio = true;
                    }

                    if (realizoCambio)
                    {
                        registros[i] = string.Join(";", camposr);
                        actualizado = true;
                    }

                    break;
                }
            }

            if (actualizado)
            {
                db.SobrescribirArchivo("persona.csv", registros);
            }

            return actualizado;
        }

        //USADO POR SUPERVISOR
        public void RegistrarLinea(string legajo, string nombre, string apellido, string dni, string fechaIngreso)
        {
            string idOperacion = Guid.NewGuid().ToString(); //identificador único

            string nuevaLinea = string.Join(";", new string[]
            {
           idOperacion,
           legajo,
           nombre,
           apellido,
           dni,
           fechaIngreso
            });

            DataBaseUtils db = new DataBaseUtils();
            db.AgregarRegistro("operacion_cambio_persona.csv", nuevaLinea);
        }
    }

}