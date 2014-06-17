using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Exceptions
{
    class ValidationException : Exception
    {
        public string mensaje { get; set; }

        public ValidationException(string msgError)
        {
            mensaje = msgError;
        }
    }

}