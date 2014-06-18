using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class ProductoACalificar
    {
        public int ID_Publicacion { get; set; }
        public DateTime Fecha { get; set; }

        public ProductoACalificar(int idPublicacion, DateTime fecha)
        {
            this.ID_Publicacion = idPublicacion;
            this.Fecha = fecha;
        }

    }
}
