using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6OBLIGATORIO.Servicios
{
    /// <summary>
    /// Interfaz que se encarga del menu de la aplicacion.
    /// csl - 180124
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que solicita una opcion por pantalla y la recoge.
        /// csl - 180124
        /// </summary>
        /// <returns></returns>
        public int menu();
    }
}
