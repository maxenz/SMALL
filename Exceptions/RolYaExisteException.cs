using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Exceptions
{
    class NombreRolYaExisteException : ApplicationException
    {
        private string nombre;

        public NombreRolYaExisteException(string n)
        {
            this.nombre = n;
        }

        public string getNombre()
        {
            return this.nombre;
        }
    }
}
