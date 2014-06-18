using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using FrbaCommerce.CapaADO;
using FrbaCommerce.Modelo;

namespace FrbaCommerce.DAO
{
    class ADOPersona : SqlConnector
    {
        // --> Obtengo las personas
        public static List<Persona> getPersonas()
        {
            List<Persona> personas = new List<Persona>();
            DataTable table = SqlConnector.retrieveDataTable("GetPersonas");
            foreach (DataRow dr in table.Rows)
            {
                Persona p = dataRowToPersona(dr);
                personas.Add(p);
            }
            return personas;
        }

        public static Persona getVendedor(int IdVendedor)
        {
            DataTable table = SqlConnector.retrieveDataTable("GetVendedor", IdVendedor);

            Persona vendedor = dataRowToPersona(table.Rows[0]);
            
            return vendedor;
        }

        // --> Paso una dataRow a un objeto Persona
        private static Persona dataRowToPersona(DataRow dr)
        {
            Persona p = new Persona();
            p.Activo = Convert.ToInt32(dr["Activo"]);
            p.Ciudad = dr["Ciudad"].ToString();
            p.Cod_Postal = Convert.ToInt64(dr["Cod_Postal"]);
            p.Departamento = dr["Departamento"].ToString();
            p.Domicilio_Calle = dr["Domicilio_Calle"].ToString();
            p.ID = Convert.ToInt64(dr["ID"]);
            p.Localidad = dr["Localidad"].ToString();
            p.Mail = dr["Mail"].ToString();
            p.Nro_Calle = Convert.ToInt64(dr["Nro_Calle"]);
            p.Piso = Convert.ToInt32(dr["Piso"]);
            p.Telefono = dr["Telefono"].ToString();

            // --> Si la persona es una empresa, tiene razon social.
            // Si es un cliente, tiene nombre y apellido. Dependiendo de eso,
            // armo la descripcion de la persona.
            string razonSocial = dr["Razon_Social"].ToString();
            if (razonSocial == "")
            {
                string nombrePer = dr["Nombre"].ToString();
                string apellidoPer = dr["Apellido"].ToString();
                p.Descripcion = apellidoPer + ", " + nombrePer;
            }
            else
            {
                p.Descripcion = razonSocial;
            }

            return p;

        }
    }
}
