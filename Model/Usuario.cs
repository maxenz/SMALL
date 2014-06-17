using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Model
{
    public class Usuario
    {
        private string _nombreUsuario;
        private List<Rol> _roles;

        public Usuario(string nombre, List<Rol> roles)
        {
            _nombreUsuario = nombre;
            _roles = roles;
        }

        public List<Rol> Roles()
        {
            return _roles;
        }
    }
}
