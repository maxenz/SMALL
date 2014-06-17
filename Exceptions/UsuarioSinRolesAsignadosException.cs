using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Exceptions
{
    class UsuarioSinRolesAsignadosException : UserException
    {
        public UsuarioSinRolesAsignadosException(string nombreUsuario) : base(nombreUsuario) { }
    }
}
