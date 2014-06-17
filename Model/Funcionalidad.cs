using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce.Model
{
    public class Funcionalidad
    {
        private int funcionalidad;
        private string nombre;

        public Funcionalidad(int func, string nomFuncionalidad)
        {
            funcionalidad = func;
            nombre = nomFuncionalidad;
        }
        public int getCodFuncionalidad()
        {
            return funcionalidad;
        }

        public override string ToString()
        {
            return nombre;
        }
        public string getNombreFuncionalidad()
        {
            return nombre;
        }
        public bool estaEnLista(List<Funcionalidad> funcionalidadesHabilitadas)
        {

            return funcionalidadesHabilitadas.Contains(this);
        }

        public bool esFuncionalidad(Funcionalidad f1, Funcionalidad f2)
        {
            return f1.getCodFuncionalidad() == f2.getCodFuncionalidad();
        }

    }
}
