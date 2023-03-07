using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL1.Entidades
{
    public class Venta
    {
        public int IdentificadorDelProducto { get; set; }
        public string? Nombredeproducto { get; set; }

        public string? DescripcionDelProducto { get; set;}

        public float PrecioDelProducto { get; set; }

        public int CantidadDelproducto { get;set; }
    }
}
