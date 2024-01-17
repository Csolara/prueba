using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6OBLIGATORIO.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menu()
        {
            int opcionseleccionada;
            Console.WriteLine("#&#&#&#&#&#&#&#&#&#&#&#&#&#&#&#&");
            Console.WriteLine("0. Cerrar menù.");
            Console.WriteLine("1. Dar de alta un nuevo cliente.");
            Console.WriteLine("2. Ordenar lista clientes.");
            Console.WriteLine("#&#&#&#&#&#&#&#&#&#&#&#&#&#&#&#&");
            opcionseleccionada = Console.ReadKey(true).KeyChar - ('0');
            return opcionseleccionada;
        }
    }
}
