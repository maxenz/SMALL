using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Exceptions
{
    class RecorridoNotFoundException : UserException
    {
        public RecorridoNotFoundException(string mensaje) : base(mensaje) { }
    }
}
