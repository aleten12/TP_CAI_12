using Datos.Seguridad;
using Persistencia.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class SeguridadPersistencia
    {
        private List<Rol> _roles;
        private List<UsuarioPerfil> _usuariosPerfil;
        private List<Perfil> _perfiles;
        private List<PerfilRol> _perfilesRoles;

        public SeguridadPersistencia()
        {
            _roles = new List<Rol>();
            _usuariosPerfil = new List<UsuarioPerfil>();
            _perfiles = new List<Perfil>();
            _perfilesRoles = new List<PerfilRol>();

            CargarRoles();
            CargarUsuariosPerfil();
            CargarPerfiles();
            CargarPerfilesRoles();
        }

        private void CargarRoles()
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            List<string> roles = dataBaseUtils.BuscarDatosPersistencia("rol.csv");
            _roles = new List<Rol>();

            foreach (var linea in roles)
            {
                var partes = linea.Split(';');
                Rol rol = new Rol(partes[0], partes[1]);
                _roles.Add(rol);
                }
            }

        private void CargarUsuariosPerfil()
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            List<string> usuariosPerfil = dataBaseUtils.BuscarDatosPersistencia("usuario_perfil.csv");

            foreach (var linea in usuariosPerfil)
            {
                var partes = linea.Split(';');
                UsuarioPerfil usuarioPerfil = new UsuarioPerfil(partes[0], partes[1]);
                _usuariosPerfil.Add(usuarioPerfil);
            }
        }
    
        private void CargarPerfiles()
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            List<string> perfil = dataBaseUtils.BuscarDatosPersistencia("perfil.csv");
            foreach (var linea in perfil)
            {
                var partes = linea.Split(';');
                Perfil nuevoPerfil = new Perfil(partes[0], partes[1]);
                _perfiles.Add(nuevoPerfil);
            }
        }
        private void CargarPerfilesRoles()
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            List<string> perfilRol = dataBaseUtils.BuscarDatosPersistencia("perfil_rol.csv");
            foreach (var linea in perfilRol)
            {
                var partes = linea.Split(';');
                PerfilRol nuevoPerfilRol = new PerfilRol(partes[0], partes[1]);
                _perfilesRoles.Add(nuevoPerfilRol);
            }
        }
        public string ObtenerPerfil(string legajo)
        {
            string idPerfil = null;

            // Buscar el idPerfil correspondiente al legajo en la lista _usuariosPerfil
            foreach (var usuario in _usuariosPerfil)
            {
                if (usuario._legajo == legajo)
                {
                    idPerfil = usuario._idPerfil.ToString();
                    break;
                }
            }

            // Si no se encuentra el legajo
            if (idPerfil == null)
            {
                return "Perfil no encontrado";
            }

            // Buscar la descripción del perfil en la lista _perfiles
            foreach (var perfil in _perfiles)
            {
                if (perfil._id == idPerfil)
                {
                    return perfil._descripcion;
                }
            }

            return "Perfil no encontrado";
        }
        public List<Rol> ObtenerRoles()
        {
            return _roles;
        }

        public List<UsuarioPerfil> ObtenerUsuariosPerfil()
        {
            return _usuariosPerfil;
        }

        public List<Perfil> ObtenerPerfiles()
        {
            return _perfiles;
        }

        public List<PerfilRol> ObtenerPerfilesRoles()
        {
            return _perfilesRoles;
        }

<<<<<<< Updated upstream
        public List<Rol> ObtenerRolesPorPerfil(string legajo)
        {
            List<Rol> rolesDelUsuario = new List<Rol>();
            string idPerfil = null;

            foreach (var usuarioPerfil in _usuariosPerfil)
            {
                if (usuarioPerfil._legajo == legajo)
                {
                    idPerfil = usuarioPerfil._idPerfil;
                    break;
                }
            }

            if (idPerfil == null)
            {
                return rolesDelUsuario;
            }

            List<string> idsRolesAsociados = new List<string>();
            foreach (var perfilRol in _perfilesRoles)
            {
                if (perfilRol._idPerfil == idPerfil)
                {
                    idsRolesAsociados.Add(perfilRol._idRol);
                }
            }

            foreach (var idRol in idsRolesAsociados)
            {
                foreach (var rol in _roles)
                {
                    if (rol._id == idRol)
                    {
                        rolesDelUsuario.Add(rol);
                        break;
                    }
                }
            }

            return rolesDelUsuario;
        }
=======
>>>>>>> Stashed changes
    }
}
