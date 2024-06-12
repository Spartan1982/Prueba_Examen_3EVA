using Prueba_Examen_3EVA.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Examen_3EVA.Servicios
{
    internal class GerenciaImplementacion : GerenciaInterfaz
    {
        public void crearFicheroVenta(List<VentaDto> listaVentas)
        {
            Console.WriteLine("Fecha a consultar");
            string fechaConsulta = Console.ReadLine();



            string contenidoFichero= crearcontenido(listaVentas,fechaConsulta);

            StreamWriter sw = new StreamWriter(String.Concat(fechaConsulta,".txt"),true);
            
            sw.Close();

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

        
        public void crearNuevoPedido(List<ProductoDto> pedido)
        {
           
            string control = "";

            do
            {
                ProductoDto producto = new ProductoDto();

                Console.WriteLine("Nombre del producto");
                producto.NombreProducto = Console.ReadLine();
                Console.WriteLine("Cantidad del producto");
                producto.CantidadProducto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Fecha deseada de entrega (dd-Mm-yyyy");
                producto.FchEntrega = Console.ReadLine();
                producto.IdProducto = autoincrementarID(pedido);

                pedido.Add(producto);

                Console.WriteLine("¿Quiere otro pedido (si(no)?");
                control = Console.ReadLine();
            } while (control.Equals("si"));

            foreach(ProductoDto producto in pedido) { 
            Console.WriteLine(producto.ToString());
            
            }
        }

        private  long autoincrementarID(List<ProductoDto> pedido)
        {
            long nuevoId;
            int tamanioLista = pedido.Count;
            if (tamanioLista > 0)
            {
                nuevoId = pedido[tamanioLista - 1].IdProducto + 1;

            }
            else
            {
                nuevoId = 0;
            }
            return nuevoId;




        }









        public void mostrarMenuGerencia(List<VentaDto>listaVentas,List<ProductoDto>listaPedidos )
        {
            
            MenuInterfaz mi = new MenuImplementacion();

            int opcionMenuGerencia;
            bool cerrarMenu = false;

            do { 
            
                opcionMenuGerencia = mi.mostrarMenuGerencia();
                switch(opcionMenuGerencia)
                {

                    case 0:
                        Console.WriteLine("Se cierra el menu");
                        cerrarMenu=true;
                        break;
                    case 1:
                        Console.WriteLine("Mostrar ventas del dia");
                        crearFicheroVenta(listaVentas);
                        break;
                    case 2:
                        Console.WriteLine("Crear nuevo pedido");
                        crearNuevoPedido(listaPedidos);
                        break;
                    default:
                        break;

                }
            
            
            }while (!cerrarMenu);

        }

        
    }
}
