using Datos.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Fase2.Negocio
{
    public class Descuento
    {
        public static decimal CalcularDescuento(
            List<Tuple<Producto, int>> carrito,
            List<CategoriaProductos> categorias,
            out decimal subtotal,
            out bool aplicaDescuento)
        {
            subtotal = 0;

            foreach (var item in carrito)
            {
                Producto producto = item.Item1;
                int cantidad = item.Item2;
                decimal totalProducto = producto.Precio * cantidad;
                subtotal += totalProducto;
            }

            aplicaDescuento = subtotal > 1000000;

            decimal descuento = aplicaDescuento ? subtotal * 0.15m : 0;
            return subtotal - descuento;
        }

    }
}
