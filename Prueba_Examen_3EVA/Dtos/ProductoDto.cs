using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Examen_3EVA.Dtos
{
    internal class ProductoDto
    {
        long idProducto;
        string nombreProducto = "aaaaaa";
        int cantidadProducto = 0;
        string fchEntrega = "31-12-9999";

        public long IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public string FchEntera { get => fchEntrega; set => fchEntrega = value; }

        override

        public string ToString()
        {
            string mensaje =
                "Producto " + this.nombreProducto + "\n" +
                "Cantidad: " + this.cantidadProducto + "\n" +
                "Fecha Entrega " + this.fchEntrega + "\n";

            return mensaje;
        }
    }
}
