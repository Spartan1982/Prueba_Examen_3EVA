using Prueba_Examen_3EVA.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Examen_3EVA.Servicios
{
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {


        public void aniadirVentas(List<VentaDto> listaVentas)
        {
            VentaDto venta = new VentaDto();
            Console.WriteLine("Importe venta");                      
            venta.ImporteVenta =Convert.ToDouble(Console.ReadLine());
            venta.IdVenta = autoincrementarID(listaVentas);
            venta.FchInstanteVenta=DateTime.Now;
            listaVentas.Add(venta);
            
        }

        private long autoincrementarID(List<VentaDto> listaVentas)
        {
            long nuevoId;
            int tamanioLista = listaVentas.Count;
            if (tamanioLista > 0)
            {
                nuevoId = listaVentas[tamanioLista - 1].IdVenta + 1;
            }
            else
            {
                nuevoId = 0;
            }
            return nuevoId;

        }

        public void calculoVentasPorFecha(List<VentaDto>listaVentas)
        {

            Console.WriteLine("FEcha a consultar (dd-MM-yyyy ");
            string fechaConsultar = Console.ReadLine();

            List<DateTime> listaFechaVentas = new List<DateTime>();
            double importeTotal = 0.0;
            
            foreach(VentaDto venta in listaVentas)
            {
                string fechaVenta = venta.FchInstanteVenta.ToString("dd - MM - yyyy ");

                if (venta.Equals(fechaConsultar))
                    listaFechaVentas.Add(venta.FchInstanteVenta);
                importeTotal = importeTotal + venta.ImporteVenta;
                        
            }


                }




        public void mostrarMenuEmpleado(List<VentaDto> listaVentas)
        {
            MenuInterfaz mi = new MenuImplementacion();

            int opcionMenuEmpleado;
            bool cerrarMenu = false;

            do
            {
                opcionMenuEmpleado = mi.mostrarMenuEmpleado();
                switch (opcionMenuEmpleado)
                {

                    case 0:
                        Console.WriteLine("Se cierrar el menu");
                        break;
                    case 1:
                        Console.WriteLine("Añadir ventas");
                        aniadirVentas(listaVentas);
                        break;
                    case 2:
                        Console.WriteLine("Calculo fecha por ventas");
                        calculoVentasPorFecha(listaVentas);
                        break;
                    default:
                        break;
                }
            } while (!cerrarMenu);

                           


            
        }
    }
}
