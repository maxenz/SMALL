using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Publicacion
    {
        public long ID { get; set; }
        public int ID_Visibilidad { get; set; }
        public int ID_Tipo_Publicacion { get; set; }
        public int ID_Estado { get; set; }
        public int ID_Persona { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
        public bool Hab_Preguntas { get; set; }
        public List<Rubro> Rubros { get; set; }
        public double ValorInicialSubasta { get; set; }

        public Publicacion(int id,int id_visibilidad, int id_tipo_publicacion, int id_estado,
                            int id_persona, string descripcion, DateTime fecha_inicio,
                            DateTime fecha_vencimiento, int stock, double precio, bool hab_preguntas,
                            List<Rubro> rubros,double vInicialSubasta)
        {
            this.ID = id;
            this.ID_Visibilidad = id_visibilidad;
            this.ID_Tipo_Publicacion = id_tipo_publicacion;
            this.ID_Estado = id_estado;
            this.ID_Persona = id_persona;
            this.Descripcion = descripcion;
            this.Fecha_Inicio = fecha_inicio;
            this.Fecha_Vencimiento = fecha_vencimiento;
            this.Stock = stock;
            this.Precio = precio;
            this.Hab_Preguntas = hab_preguntas;
            this.Rubros = rubros;
            this.ValorInicialSubasta = vInicialSubasta;
        }
    }
}
