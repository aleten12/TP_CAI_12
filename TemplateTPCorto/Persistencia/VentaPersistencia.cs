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
    public class VentaPersistencia
    {
        //private Guid idUsuario = new Guid("784c07f2-2b26-4973-9235-4064e94832b5");

        public ResultadoVenta agregarVenta(Venta venta)
        {
            var jsonRequest = JsonConvert.SerializeObject(venta);

            HttpResponseMessage response = WebHelper.Post("/api/Venta/AgregarVenta", jsonRequest);

            if (response.IsSuccessStatusCode)
            {
                return new ResultadoVenta
                {
                    Exito = true,
                    IdProducto = venta.IdProducto
                };
            }
            else
            {
                return new ResultadoVenta
                {
                    Exito = false,
                    IdProducto = venta.IdProducto,
                    ErrorMensaje = $"Status code: {response.StatusCode}"
                };
            }
        }
    }
}
