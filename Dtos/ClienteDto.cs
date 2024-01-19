using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6OBLIGATORIO.Dtos
{
    internal class ClienteDto
    {
        long idCliente;

        string nombreCliente = "aaaaa";

        string apellidosCliente = "aaaaa";

        string nombreCompletoCliente = "aaaaa";

        int edadCliente = 111;


        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public int EdadCliente { get => edadCliente; set => edadCliente = value; }

        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, int edadCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.nombreCompletoCliente = nombreCliente + apellidosCliente;
            this.edadCliente = edadCliente;
        }

        public ClienteDto()
        {

        }
        override
        public string ToString()
        {
            string cliente = "idCliente:  " + this.idCliente +
                "    nombreCliente:  " + this.nombreCliente +
                "    apellidiosCliente:  " + this.apellidosCliente +
                "    nombreCompletoCliente:  " + this.nombreCliente + this.apellidosCliente +
                "    edadCliente:  " + this.edadCliente;
            return cliente;
        }
    }
}
