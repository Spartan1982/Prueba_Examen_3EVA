using Prueba_Examen_3EVA.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Examen_3EVA.Servicios
{
    internal interface GerenciaInterfaz
    {
        public void mostrarMenuGerencia(List<VentaDto> listaVentas, List<ProductoDto> listaPedido);


        public void crearFicheroVenta(List<VentaDto> listaVentas);

        public void crearNuevoPedido(List<ProductoDto> listaPedido);
    }
}
