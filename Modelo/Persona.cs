using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Persona
    {
        public long ID { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Domicilio_Calle { get; set; }
        public long Nro_Calle { get; set; }
        public int Piso { get; set; }
        public string Departamento { get; set; }
        public string Localidad { get; set; }
        public long Cod_Postal { get; set; }
        public string Ciudad { get; set; }
        public int Activo { get; set; }
        public string Descripcion { get; set; }
    }
}
