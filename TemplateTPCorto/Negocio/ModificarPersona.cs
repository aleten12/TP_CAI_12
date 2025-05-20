using System;
using System.Collections.Generic;
using System.Data.Common;
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

        public bool GuardarDatosModificados(string legajo, string nombre, string apellido, string dni, string fechaIngreso)
        {
            if (string.IsNullOrWhiteSpace(legajo))
            {
                return false;
            }

            DataBaseUtils db = new DataBaseUtils();
            List<string> registros = db.BuscarRegistro("persona.csv");
            bool actualizado = false;

            for (int i = 1; i < registros.Count; i++)
            {
                string[] campos = registros[i].Split(';');

                if (campos[0] == legajo)
                {
                    bool realizoCambio = false;

                    if (!string.IsNullOrWhiteSpace(nombre) && campos[1] != nombre)
                    {
                        campos[1] = nombre;
                        realizoCambio = true;
                    }

                    if (!string.IsNullOrWhiteSpace(apellido) && campos[2] != apellido)
                    {
                        campos[2] = apellido;
                        realizoCambio = true;
                    }

                    if (!string.IsNullOrWhiteSpace(dni) && campos[3] != dni)
                    {
                        campos[3] = dni;
                        realizoCambio = true;
                    }


                    if (!string.IsNullOrWhiteSpace(fechaIngreso) && campos[4] != fechaIngreso)
                    {
                        campos[4] = fechaIngreso;
                        realizoCambio = true;
                    }

                    if (realizoCambio)
                    {
                        registros[i] = string.Join(";", campos);
                        actualizado = true;
                    }

                    break;
                }
            }

            if (actualizado)
            {
                RegistrarLinea(legajo, nombre, apellido, dni, fechaIngreso);
            }

            return actualizado;
        }

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

