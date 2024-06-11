using Prueba_Examen_3EVA.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Examen_3EVA.Servicios
{
    internal class GerenciaImplementacion : GerenciaInterfaz
    {
        public void mostrarMenuGerencia(List<VentaDto> listaVentas)
        {
            Console.WriteLine("Fecha a consultar");
            string fechaConsulta = Console.ReadLine();

            string contenidoFichero= crearcontenido(listaVentas,fechaConsulta);


        }

        private void escribirFichero(StreamWriter sw, string contenido)
        {
            sw.Write(contenido);
        }

        private string crearcontenido(List<VentaDto> listaVentas, string fechaConsulta)
        {
            string contenido = "";

            foreach (VentaDto venta in listaVentas)
            {
                string fechaVenta= venta.FchInstanteVenta.ToString("dd-MM-yyyy");
                if (fechaVenta.Equals(fechaConsulta))
                {
                    contenido = contenido + venta.ToString();
                }
            }
            return contenido;

        }

        void GerenciaInterfaz.crearcontenido(List<VentaDto> listaVentas, string fechaConsulta)
        {
            throw new NotImplementedException();
        }

        public void mostrarMenuGerencia(List<VentaDto>listaVentas)
        {
            MenuInterfaz mi = new MenuImplementacion();

            int opcionMenuGerencia;
            bool cerrarMenu = false;

            do { 
            
                opcionMenuGerencia = mi.
            
            
            }while (true);

        }
    }
}
