using System.Collections.Generic;

namespace FrbaCommerce.Model
{
    public class Rol
    {
        public int Codigo { get; set; }
        public string Nombre;
        public bool Habilitado;
        public List<int> Funcionalidades;

        public Rol(string nombre)
        {
            Nombre = nombre;
        }
        
        public Rol(int cod, string nombre, bool habilitado)
        {
            Codigo = cod;
            Nombre = nombre;
            Habilitado = habilitado;
        }
        
        public Rol(string nombre, List<int> funcionalidades )
        {
            Nombre = nombre;
            Funcionalidades = funcionalidades;
            Habilitado = true;
        }

    }
}