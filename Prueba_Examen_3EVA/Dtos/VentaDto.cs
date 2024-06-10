using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Examen_3EVA.Dtos
{
    internal class VentaDto
    {
        long idVenta;
        double importeVenta = 0.0;
        DateTime fchInstanteVenta = DateTime.Now;

        public long IdVenta { get => idVenta; set => idVenta = value; }
        public double ImporteVenta { get => importeVenta; set => importeVenta = value; }
        public DateTime FchInstanteVenta { get => fchInstanteVenta; set => fchInstanteVenta = value; }

        override

        public string ToString()
        {
            string mensaje = "..........\n" +
            "Venta numero: " + this.idVenta + "\n" +
            "Euros: " + this.importeVenta + "\n" +
            "Instante de compra: " + this.FchInstanteVenta.ToString("dd-MM-yyyy") + "\n";


            return mensaje;
        }
    }
}
