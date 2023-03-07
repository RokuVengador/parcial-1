using PARCIAL1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL1.Negocio
{
    public class ClsVenta
    {
        public string Cobro(Venta venta)
        {
            float total = venta.PrecioDelProducto * venta.PrecioDelProducto;

            if (total > 50)
            {
                float total2 = total - 10;

                return $"Total a pagar: \n precio original {total} \n y el precio con descuento es de: {total2}";
            }
            else
            {
                return $"Total a pagar: precio original{total}";
            }


        }

    }

}
