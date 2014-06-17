using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Model
{
    public class Persona
    {
        public string eMail { get; set; }
        public string telefono { get; set; }
        public string codPostal { get; set; }
        public string ciudad { get; set; }
        public string calle { get; set; }
        public int nroCalle { get; set; }
        public string piso { get; set; }
        public string departamento { get; set; }
        public string localidad { get; set; }
    }
}
