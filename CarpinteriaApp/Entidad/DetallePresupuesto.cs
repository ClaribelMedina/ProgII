using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.Entidad
{
    internal class DetallePresupuesto
    {

        public Productos Producto { get; set; }
        public int Cantidad { get; set; }
        public DetallePresupuesto(Productos p, int c)
        {
            Producto= p;
            Cantidad= c;
        }

        public double CalcularSubtotal()
        {
            return Cantidad*Producto.Precio;
        }

    }
}
