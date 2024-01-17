using Ejercicio6OBLIGATORIO.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6OBLIGATORIO.Servicios
{
    internal class ImplementacionCliente : InterfazCliente
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto cliente = crearNuevoCliente();
            listaAntigua.Add(cliente);

        }
        private ClienteDto crearNuevoCliente()
        {
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("Introduzca el id: ");
            nuevoCliente.IdCliente = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("Introduzca los apellidos: ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();

            Console.WriteLine("Introduzca la edad: ");
            nuevoCliente.EdadCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(nuevoCliente.NombreCliente + " " + nuevoCliente.ApellidosCliente + " " + nuevoCliente.EdadCliente);

            return nuevoCliente;
        }
    }
}
