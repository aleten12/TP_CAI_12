using Persistencia.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class GestorCambioCredenciales
    {
        private readonly DataBaseUtils dbUtils = new DataBaseUtils();

        public bool AplicarCambioCredencial(string linea)
        {
            ModificarCredencial mc = new ModificarCredencial();
            bool aplicado = mc.AplicarCambioContrasena(linea);

            if (aplicado)
                EliminarOperacion("operacion_cambio_credencial.csv", linea);

            return aplicado;
        }

        public void RechazarCambioCredencial(string linea)
        {
            EliminarOperacion("operacion_cambio_credencial.csv", linea);
        }

        private void EliminarOperacion(string archivo, string linea)
        {
            List<string> lineas = dbUtils.BuscarDatosPersistencia(archivo);
            string idEliminar = linea.Split(';')[0].Trim();

            var nuevasLineas = lineas
                .Where(l => !string.IsNullOrWhiteSpace(l) && l.Split(';')[0].Trim() != idEliminar)
                .ToList();

            dbUtils.SobrescribirArchivo(archivo, nuevasLineas);
        }
    }
}
