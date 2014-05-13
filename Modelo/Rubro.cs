using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Rubro
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }

        public Rubro(int id,string descripcion)
        {
            this.ID = id;
            this.Descripcion = descripcion;
        }

    }
}
