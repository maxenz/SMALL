using System;
using System.Data;
using FrbaCommerce.Model;

namespace FrbaCommerce.CapaADO
{
    class DAOPersona : SqlConnector
    {
        public static Persona getPersona(int idPersona)
        {
            var table = retrieveDataTable("getPersona", idPersona);
            return dataRowToPersona(table.Rows[0]);
        }

        private static Persona dataRowToPersona(DataRow dr)
        {
            var persona = new Persona
            {
                eMail = dr["Mail"].ToString(),
                calle = dr["Domicilio_Calle"].ToString(),
                nroCalle = Convert.ToInt32(dr["Nro_Calle"]),
                ciudad = dr["Ciudad"].ToString(),
                codPostal = dr["Cod_Postal"].ToString(),
                departamento = dr["Departamento"].ToString(),
                localidad = dr["Localidad"].ToString(),
                piso = dr["Piso"].ToString(),
                telefono = dr["Telefono"].ToString()
            };
            return persona;
        }

        public static int AgregarPersona(Persona persona)
        {
            return executeProcedureWithReturnValue("agregarPersona", persona.eMail, Convert.ToInt32(persona.telefono), persona.calle,
                persona.nroCalle, Convert.ToInt32(persona.piso), persona.departamento, persona.localidad,
                persona.codPostal, persona.ciudad, 1);
        }

        public static void UpdatePersona(Persona persona, int id)
        {
            executeProcedure("updatePersona", id, persona.eMail, Convert.ToInt32(persona.telefono), persona.calle,
                persona.nroCalle, Convert.ToInt32(persona.piso), persona.departamento, persona.localidad,
                persona.codPostal, persona.ciudad);
        }

        public static void BajaPersona(int id, int act)
        {
            executeProcedure("activarPersona", id, act);
        }
    }
}