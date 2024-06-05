using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Examen_3EVA.Servicios
{
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {
        public int mostrarMenuEmpleado()
        {
            int opcionEmpleado;

            
            Console.WriteLine("1.aniadir ventas");
            Console.WriteLine("2.calculo total de ventas");
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("Opcion erronea");
            opcionEmpleado = Convert.ToInt32(Console.ReadLine());
            return opcionEmpleado;

        }
        public void aniadirVentas()
        {

        }

        void EmpleadoInterfaz.mostrarMenuEmpleado()
        {
            throw new NotImplementedException();
        }
    }
}
