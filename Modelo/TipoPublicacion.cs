using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class TipoPublicacion
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public TipoPublicacion(string descripcion)
        {
            this.Descripcion = descripcion;
        }
    }
}
