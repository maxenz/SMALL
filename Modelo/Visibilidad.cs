﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Modelo
{
    public class Visibilidad
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public double Porcentaje { get; set; }
        public bool Activo { get; set; }

        public Visibilidad(int id,string descripcion, double precio, double porcentaje, bool activo)
        {
            this.ID = id;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Porcentaje = porcentaje;
            this.Activo = activo;
        }
    }
}
