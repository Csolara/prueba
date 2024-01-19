using Ejercicio6OBLIGATORIO.Dtos;
using Ejercicio6OBLIGATORIO.Servicios;
using System.Reflection.PortableExecutable;

namespace Ejercicio6OBLIGATORIO.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion.
    /// csl - 180124
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo principal de la aplicacion.
        /// csl - 180124
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();

            MenuInterfaz mi = new MenuImplementacion();
            InterfazCliente ic = new ImplementacionCliente();

            bool cerrarMenu = false;
            int recogido;

            while(!cerrarMenu)
            {
                recogido = mi.menu();

                    switch(recogido)
                {
                    case 0:
                        Console.WriteLine("Ha seleccionado cerrar menu.");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Ha seleccionado dar de alta nuevo cliente");
                        ic.darAltaCliente(listaClientes);                      
                        break;
                    case 2:
                        Console.WriteLine("Ha seleccionado ordenar lista clientes.");
                        ic.ordenarCliente(listaClientes);
                        break;
                    default:
                        Console.WriteLine("La opcion que ha seleccionado no coincide con ninguna");
                        break;
                }
                
            }

        }

    }

}