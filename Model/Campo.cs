using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCommerce.Exceptions;
using FrbaCommerce.Model;

namespace FrbaCommerce.Model
{
    public class Campo : ICampoAbstracto
    {
        public string Texto { get; set; }
        public string Nombre { get; set; }
        public bool Obligatorio { get; set; }
        public Controller.TipoValidacion tipoVal { get; set; }

        public Campo(string nom, string text, bool oblig, Controller.TipoValidacion val)
        {
            Nombre = nom;
            Texto = text;
            Obligatorio = oblig;
            tipoVal = val;
        }
        //Metodo que valida si el campo cumple con las restricciones impuestas.
        public void Validar()
        {
            var mensaje = "";
            bool validado = true;

            if (Obligatorio && Texto == "") { mensaje += "-El campo " + this.Nombre + " es obligatorio." +Environment.NewLine; validado = false; }
            try
            {
                Controller.validarTipo(this);
            }
            catch (ValidationException ex)
            {
                mensaje += ex.mensaje;
                validado = false;
            }

            if (!validado)
            {
                throw new ValidationException(mensaje);
            }
        }
    }
}
