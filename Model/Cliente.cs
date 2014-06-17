using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Model
{
    public class Cliente
    {
        // Nombre.
        // Apellido.
        // DNI.
        // Tipo de documento
        // Fecha de Nacimiento.

        public Persona Persona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Cuil { get; set; }
        public byte TipoDoc { get; set; }
        public DateTime FechaDeNacimiento { get; set; }

        public Cliente(Persona per,string nomb,string apell,string doc,string cuil,byte tipo,DateTime fechaNac)
        {
            Persona = per;
            Nombre = nomb;
            Apellido = apell;
            Documento = doc;
            Cuil = cuil;
            TipoDoc = tipo;
            FechaDeNacimiento = fechaNac;
        }
    }
}
