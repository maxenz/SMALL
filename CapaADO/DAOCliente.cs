using System;
using System.Collections.Generic;
using System.Data;
using FrbaCommerce.Model;

namespace FrbaCommerce.CapaADO
{
    public class DAOCliente:SqlConnector
    {
        public static DataTable getClienteTable()
        {
            return retrieveDataTable("getClientes");
        }

        public static Cliente getCliente(int id)
        {
            var table = retrieveDataTable("getCliente", id);
            return dataRowToCliente(table.Rows[0]);
        }

        public static void UpdateCliente(Cliente cliente, int id)
        {
            DAOPersona.UpdatePersona(cliente.Persona, id);
            executeProcedure("updateCliente", id, cliente.Nombre, cliente.Apellido, cliente.TipoDoc, cliente.Documento,
                cliente.Cuil, cliente.FechaDeNacimiento);
        }

        public static void AgregarCliente(Cliente cliente)
        {
            var id = DAOPersona.AgregarPersona(cliente.Persona);
            executeProcedure("agregarCliente", id, cliente.Nombre, cliente.Apellido, cliente.TipoDoc, cliente.Documento,
                cliente.Cuil, cliente.FechaDeNacimiento);
        }

        public static bool existeDni(string dni, int tipo)
        {
            var dt = retrieveDataTable("getClienteDni", dni,tipo);
            return dt.Rows.Count > 0;
        }

        public static bool existeTelefono(string tel)
        {
            var dt = retrieveDataTable("getClienteTel", tel);
            return dt.Rows.Count > 0;
        }

        private static Cliente dataRowToCliente(DataRow dr)
        {
            var persona = DAOPersona.getPersona(Convert.ToInt32(dr["ID_Persona"]));
            var cliente = new Cliente(persona, dr["Nombre"].ToString(), dr["Apellido"].ToString(),
                dr["Num_Doc"].ToString(), dr["Cuil"].ToString(), Convert.ToByte(dr["Tipo_Doc"]),
                Convert.ToDateTime(dr["Fecha_Nac"]));
            return cliente;
        }

        public static void BajaCliente(int id)
        {
            DAOPersona.BajaPersona(id,0);
        }

        public static DataTable TiposDocumento()
        {
            return retrieveDataTable("getTiposDocumento");
        }
    }
}
