using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Ventas;
using Persistencia;

namespace Negocio.Fase2.Negocio
{
    public class VentasNegocio
    {
        public List<Cliente> obtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            ClientePersistencia clientePersistencia = new ClientePersistencia();

            clientes = clientePersistencia.obtenerClientes();

            return clientes;
        }

        public List<CategoriaProductos> obtenerCategoriaProductos()
        {
            List<CategoriaProductos> categoriaProductos = new List<CategoriaProductos>();

            CategoriaProductos p1 = new CategoriaProductos("1", "Audio");
            categoriaProductos.Add(p1);

            CategoriaProductos p2 = new CategoriaProductos("2", "Celulares");
            categoriaProductos.Add(p2);

            CategoriaProductos p3 = new CategoriaProductos("3", "Electro Hogar");
            categoriaProductos.Add(p3);

            CategoriaProductos p4 = new CategoriaProductos("4", "Informática");
            categoriaProductos.Add(p4);

            CategoriaProductos p5 = new CategoriaProductos("5", "Smart TV");
            categoriaProductos.Add(p5);

            return categoriaProductos;
        }

        public string ValidarStockMensaje(int cantidadIngresada, int stockDisponible)
        {
            if (cantidadIngresada <= 0)
            {
                return "La cantidad debe ser mayor a cero.";
            }

            if (cantidadIngresada > stockDisponible)
            {
                return "La cantidad supera el stock disponible." + Environment.NewLine + $"Hay {stockDisponible} unidades en stock.";
            }

            return ""; // Sin errores
        }
    }
}
