using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class EstadoPublicacion
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public EstadoPublicacion(int id,string descripcion)
        {
            this.ID = id;
            this.Descripcion = descripcion;
        }
    }
}
