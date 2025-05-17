using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Seguridad
{
    public class Rol
    {
        public string _id { get; set; }
        public string _descripcion { get; set; }

        public Rol(string id, string descripcion)
        {
            _id = id;
            _descripcion = descripcion;
        }
    }

    public class UsuarioPerfil
    {
        public string _legajo { get; set; }
        public string _idPerfil { get; set; }

        public UsuarioPerfil(string legajo, string idPerfil)
        {
            _legajo = legajo;
            _idPerfil = idPerfil;
        }
    }

    public class Perfil
    {
        public string _id { get; set; }
        public string _descripcion { get; set; }

        public Perfil(string id, string descripcion)
        {
            _id = id;
            _descripcion = descripcion;
        }
    }

    public class PerfilRol
    {
        public string _idPerfil { get; set; }
        public string _idRol { get; set; }

        public PerfilRol(string idPerfil, string idRol)
        {
            _idPerfil = idPerfil;
            _idRol = idRol;
        }
    }

}
