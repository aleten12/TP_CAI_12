using Persistencia.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class GestorOperaciones
    {
        private readonly DataBaseUtils dbUtils;

        public GestorOperaciones()
        {
            dbUtils = new DataBaseUtils();
        }

        public List<string> ObtenerCambioCredenciales()
        {
            var lineas = dbUtils.BuscarDatosPersistencia("operacion_cambio_credencial.csv");
            return lineas.Skip(1).ToList(); // salteamos el encabezado
        }

        public List<string> ObtenerCambioPersonas()
        {
            var lineas = dbUtils.BuscarDatosPersistencia("operacion_cambio_persona.csv");
            return lineas.Skip(1).ToList(); // salteamos el encabezado
        }
    }
}
