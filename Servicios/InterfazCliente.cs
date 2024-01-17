using Ejercicio6OBLIGATORIO.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6OBLIGATORIO.Servicios
{
    internal interface InterfazCliente
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua);
    }
}
