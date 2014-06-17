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
    class ADOFacturacion : SqlConnector
    {
        // --> Obtengo la ultima publicacion facturada del usuario pedido
        public static DataTable getLastPublicacionFacturada(int pUsr)
        {
            return SqlConnector.retrieveDataTable("GetLastPublicacionFacturada", pUsr);
        }

        public static DataTable getPublicacionesAFacturar(int cantAFacturar, DateTime fechaUltimaFacturada,
            int idPersona)
        {
            return SqlConnector.retrieveDataTable("GetPublicacionesAFacturar", cantAFacturar, fechaUltimaFacturada,
                idPersona);
        }

        public static DataTable setFactura(string formaDePago, string descFormaDePago, int idPersona)
        {
            return SqlConnector.retrieveDataTable("SetFactura", formaDePago, descFormaDePago, idPersona, DateTime.Now);
        }

        public static DataTable getComprasPublicacion(int idPublicacion)
        {
            return SqlConnector.retrieveDataTable("GetComprasPublicacion", idPublicacion);
        }

    }
}
