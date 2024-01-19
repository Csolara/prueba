using Ejercicio6OBLIGATORIO.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6OBLIGATORIO.Servicios
{
    /// <summary>
    /// Interfaz que se encarga de los clientes.
    /// csl - 180124
    /// </summary>
    internal interface InterfazCliente
    {
        /// <summary>
        /// Metodo que se encarga de crear un nuevo cliente.
        /// csl - 180124
        /// </summary>
        public void darAltaCliente(List<ClienteDto> listaAntigua);
        /// <summary>
        /// Metodo que se encarga de ordenar los clientes.
        /// csl - 180124
        /// </summary>
        public void ordenarCliente(List<ClienteDto> listaAntigua);
    }
}
