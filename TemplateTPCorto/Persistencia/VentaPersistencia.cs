using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class VentaPersistencia
    {
        private Guid idUsuario = new Guid("784c07f2-2b26-4973-9235-4064e94832b5");

        /*
        public bool agregarVenta(venta)
        {
            var jsonRequest = JsonConvert.SerializeObject(venta);

            HttpResponseMessage response = WebHelper.Post("Venta/AgregarVenta", jsonRequest);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
        */
    }
}
