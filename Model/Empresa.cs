using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Model
{

    public class Empresa
    {
        public Persona Persona { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public string NombreContacto { get; set; }
        public DateTime FechaDeCreacion { get; set; }

        public Empresa(Persona per,string rSocial,string cuit,string nomContacto,DateTime fechaCreacion)
        {
            Persona = per;
            RazonSocial = rSocial;
            Cuit = cuit;
            NombreContacto = nomContacto;
            FechaDeCreacion = fechaCreacion;
        }

    }
}