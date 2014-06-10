using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class RubroPublicacion
    {
        public int idPublicacion { get; set; }
        public int idRubro { get; set; }

        public RubroPublicacion(int idPublicacion,int idRubro)
        {
            this.idPublicacion = idPublicacion;
            this.idRubro = idRubro;
        }

    }
}
