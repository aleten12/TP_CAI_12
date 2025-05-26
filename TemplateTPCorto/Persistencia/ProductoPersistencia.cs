using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Datos.Ventas;
using Newtonsoft.Json;
using Persistencia.WebService.Utils;

namespace Persistencia
{
    public class ProductoPersistencia
    {
        public List<Producto> obtenerProductosPorCategoria(String categoria)
        {
            List<Producto> listadoProductos = new List<Producto>();

            // Llamo al WS
            HttpResponseMessage response = WebHelper.Get("/api/Producto/TraerProductosPorCategoria?catnum=" + categoria);

            if (response.StatusCode.Equals(HttpStatusCode.OK))
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                listadoProductos = JsonConvert.DeserializeObject<List<Producto>>(contentStream);
            }


            return listadoProductos;
        }
    }
}
