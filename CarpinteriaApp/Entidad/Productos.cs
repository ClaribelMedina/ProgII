using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp.Entidad
{
    internal class Productos
    {

        public int ProductoNro { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public bool Activo { get; set; }

        public Productos(int productoNro, string nombre, double precio, bool activo)
        {
            ProductoNro = productoNro;
            Nombre = nombre;
            Precio = precio;
            Activo = activo;

        }

        public Productos()
        {
            ProductoNro = 0;
            Nombre = string.Empty;
            Activo = false;
            Precio = 0;

        }

        public override string ToString()
        {
            return "";
        }

    }
}
