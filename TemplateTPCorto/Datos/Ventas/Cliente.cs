using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Ventas
{
    public class Cliente
    {
        Guid _id;
        String _nombre;
        String _apellido;
        String _dni;
        String _direccion;
        String _telefono;
        String _email;
        DateTime _fechaNacimiento;
        DateTime _fechaAlta;
        DateTime? _fechaBaja;
        String _host;

        public Guid Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Dni { get => _dni; set => _dni = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = value; }
        public string Host { get => _host; set => _host = value; }

        public override string ToString()
        {
            return Apellido + ", " + Nombre + "(" + Dni + ")";
        }

    }
}
