using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FrbaCommerce.CapaADO;

namespace FrbaCommerce.CapaADO
{
    class ADOListados : SqlConnector //Armar los procedures!!!!
    {
        public static DataTable getTop5VendedoresMayorCantidadProductosNoVendidos(int Mes, int Trimestre, int Anio)
        {
            return SqlConnector.retrieveDataTable("getTop5VendedoresMayorCantidadProductosNoVendidos", Anio, Trimestre, Mes);
        }
        public static DataTable getTop5VendedoresMayorFacturacion(int Trimestre, int Anio)
        {
            return SqlConnector.retrieveDataTable("getTop5VendedoresMayorFacturacion", Anio, Trimestre);
        }
        public static DataTable getTop5VendedoresMayorCalificacion(int Trimestre, int Anio)
        {
            return SqlConnector.retrieveDataTable("getTop5VendedoresMayorCalificacion", Anio, Trimestre);
        }
        public static DataTable getTop5ClientesMayorCantPubliSinCalificar(int Trimestre, int Anio)
        {
            return SqlConnector.retrieveDataTable("getTop5ClientesMayorCantPubliSinCalificar", Anio, Trimestre);
        }
    }
}