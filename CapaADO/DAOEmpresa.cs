using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Model;

namespace FrbaCommerce.CapaADO
{
    class DAOEmpresa: SqlConnector
    {
        public static Empresa getEmpresa(int idPersona)
        {
            var table = retrieveDataTable("getEmpresa", idPersona);
            return dataRowToEmpresa(table.Rows[0]);
        }
       
        public static DataTable getEmpresaTable()
        {
            return retrieveDataTable("getEmpresas");
        }

        private static Empresa dataRowToEmpresa(DataRow dr)
        {
            var persona = DAOPersona.getPersona(Convert.ToInt32(dr["ID_Persona"]));
            var empresa = new Empresa(persona, dr["Razon_Social"].ToString(), dr["Cuit"].ToString(),
                dr["Nombre_Contacto"].ToString(), Convert.ToDateTime(dr["Fecha_Creacion"]));
            return empresa;
        }

        public static void AgregarEmpresa(Empresa empresa)
        {
            var id = DAOPersona.AgregarPersona(empresa.Persona);
            executeProcedure("agregarEmpresa",id, empresa.RazonSocial, empresa.Cuit, empresa.NombreContacto, empresa.FechaDeCreacion);
        }


        public static void UpdateEmpresa(Empresa empresa, int id)
        {
            DAOPersona.UpdatePersona(empresa.Persona,id);
            executeProcedure("updateEmpresa", empresa.NombreContacto,id);
        }

        public static void BajaEmpresa(int id)
        {
            DAOPersona.BajaPersona(id,0);
        }
    }
}