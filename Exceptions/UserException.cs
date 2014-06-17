using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Exceptions
{
    class UserException : ApplicationException
    {
        private string nombre;
        public UserException(string nombreUsuario)
        {
            this.nombre = nombreUsuario;
        }

        public string getNombreUsuario()
        {
            return this.nombre;
        }
    }
}
