using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Exceptions
{
    class UsuarioNoEncontradoException : UserException
    {
        public UsuarioNoEncontradoException(string nombreUsuario) : base(nombreUsuario) { }
    }
}
