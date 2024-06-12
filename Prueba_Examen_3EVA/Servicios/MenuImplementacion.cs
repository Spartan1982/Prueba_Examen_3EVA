using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Examen_3EVA.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int mostrarMenuSeleccion() { 

        int opcionUsuario;

            Console.WriteLine("0.Se cierra el menu");
            Console.WriteLine("1.Menu EMPLEADO");
            Console.WriteLine("2.Menu GERENCIA");
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("Opcion erronea");
            opcionUsuario=Convert.ToInt32(Console.ReadLine());
            return opcionUsuario;
            
    }
        public int mostrarMenuEmpleado()
        {
            int opcionMenuempleado;
            Console.WriteLine("0.Se cierra el menu");
            Console.WriteLine("1.Añadir ventas");
            Console.WriteLine("2.Calculo fecha por ventas");
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("Opcion erronea");
            opcionMenuempleado=Convert.ToInt32(Console.ReadLine()); 
            return opcionMenuempleado;


        }

        public int mostrarMenuGerencia()
        {
            int opcionMenuGerencia;
            Console.WriteLine("0.Se cierra menu");
            Console.WriteLine("1.Mostrar ventas del dia");
            Console.WriteLine("2.Crear nuevo pedido");
            Console.WriteLine("Opcion erronea");
            opcionMenuGerencia=Convert.ToInt32(Console.ReadLine()); 

            return opcionMenuGerencia;
        }


    }
}
