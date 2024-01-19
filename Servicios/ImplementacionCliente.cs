using Ejercicio6OBLIGATORIO.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6OBLIGATORIO.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz del cliente.
    /// csl - 180124
    /// </summary>
    internal class ImplementacionCliente : InterfazCliente
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto cliente = crearNuevoCliente();
            listaAntigua.Add(cliente);
            Console.WriteLine(listaAntigua.ToString());

        }
        /// <summary>
        /// Metodo que crea un nuevo cliente.
        /// </summary>
        /// <returns></returns>
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
        public void ordenarCliente(List<ClienteDto> listaAntigua)
        {

            if (3 > listaAntigua.Count)
            {
                Console.WriteLine("Tiene que existir almenos 3 clientes");
            }
            else
            {                
                for (int i = 0; i < listaAntigua.Count - 1; i++)
                {
                    for (int k = 0; k < listaAntigua.Count - 1 - i; k++)
                    {
                        if (listaAntigua.[k] > listaAntigua[k + 1])
                        {
                            int aux = listaAntigua[k];
                            listaAntigua[k] = listaAntigua[k + 1];
                            listaAntigua[k + 1] = aux;
                        }
                    }

                }

            }
        }
    }
}
