using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FrbaCommerce.CapaADO
{
    public class DAOFuncionalidades: SqlConnector
    {
        public static DataTable getFuncionalidades()
        {
            return retrieveDataTable("getFuncionalidades");
        }
    }
}
