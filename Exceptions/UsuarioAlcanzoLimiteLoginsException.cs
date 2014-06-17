using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Exceptions
{
    class UsuarioAlcanzoLimiteLoginsException : UserException
    {
        public UsuarioAlcanzoLimiteLoginsException(string nombreUsuario) : base(nombreUsuario) { }
    }
}
