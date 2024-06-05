using Prueba_Examen_3EVA.Dtos;
using Prueba_Examen_3EVA.Servicios;

namespace Prueba_Examen_3EVA.Controladores
{

    class Progra
    {

        public static void Main(string[] args)
        {
            List<VentaDto > listaVentas = new List<VentaDto>();

            MenuInterfaz mi = new MenuImplementacion();
            EmpleadoInterfaz ei = new EmpleadoImplementacion();
            GerenciaInterfaz gi = new GerenciaImplementacion();

            int opcionUsuario;
            bool cerrarMenu = false;

            do
            {
                opcionUsuario = mi.mostrarMenuSeleccion();
                switch(opcionUsuario)
                {

                    case 0:
                        Console.WriteLine("Se cierra el menu");
                        break;
                    case 1:
                        Console.WriteLine("Menu EMPLEADO");
                        ei.aniadirVentas();
                        ei.mostrarMenuEmpleado();
                            break;
                    case 2:
                        Console.WriteLine("Menu GERENCIA");
                        gi.mostrarMenuGerencia();
                        break;
                    default:
                        Console.WriteLine("Opcion erronea");
                        break;
                }

            } while (!cerrarMenu);

        }

    }
}