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
    class ADOPublicacion : SqlConnector
    {
        // --> Obtengo el ultimo codigo de publicacion
        public static int getNewPublicacionNumber()
        {
            DataTable dt = SqlConnector.retrieveDataTable("GetNewPublicacionNumber");
            return Convert.ToInt32(dt.Rows[0]["ID"]);
        }


        // --> Obtengo la lista de estados de publicacion
        public static List<EstadoPublicacion> getEstadosPublicacion() {

            List<EstadoPublicacion> estadosPublicacion = new List<EstadoPublicacion>();
            DataTable table = SqlConnector.retrieveDataTable("GetEstadosPublicacion");
            foreach (DataRow dr in table.Rows)
            {
                EstadoPublicacion estadoPublicacion = dataRowToEstadoPublicacion(dr);
                estadosPublicacion.Add(estadoPublicacion);
            }
            return estadosPublicacion;
        }


        // --> Obtengo un estado de publicacion pasandole el id
        public static EstadoPublicacion getEstadoPublicacion(int id)
        {
            DataTable table = SqlConnector.retrieveDataTable("GetEstadoPublicacion", id);
            DataRow dr = table.Rows[0];
            EstadoPublicacion estadoPublicacion = dataRowToEstadoPublicacion(dr);
                       
            return estadoPublicacion;
        }


        // --> Paso una datarow a un objeto EstadoPublicacion
        private static EstadoPublicacion dataRowToEstadoPublicacion(DataRow dr)
        {
            return new EstadoPublicacion(Convert.ToInt32(dr["ID"]),dr["Descripcion"].ToString());
        }


        // --> Obtengo una publicacion pasandole el id
        public static Publicacion getPublicacion(int id)
        {
            DataTable table = SqlConnector.retrieveDataTable("GetPublicacion",id);
            Publicacion p = dataRowToPublicacion(table.Rows[0]);
            p.Rubros = getRubrosFromPublicacion(p);
            return p;                
        }


        // --> Obtengo los tipos de publicacion
        public static List<TipoPublicacion> getTiposDePublicacion()
        {
            List<TipoPublicacion> tiposDePublicacion = new List<TipoPublicacion>();
            DataTable table = SqlConnector.retrieveDataTable("GetTiposPublicacion");
            foreach (DataRow dr in table.Rows)
            {
                TipoPublicacion tip_pub = dataRowToTipoPublicacion(dr);
                tiposDePublicacion.Add(tip_pub);
            }
            return tiposDePublicacion;
        }


        // --> Obtengo un tipo de publicacion pasandole el id
        public static TipoPublicacion getTipoPublicacion(int id)
        {
            DataTable table = SqlConnector.retrieveDataTable("GetTipoPublicacion", id);
            DataRow dr = table.Rows[0];
            TipoPublicacion tip_pub = dataRowToTipoPublicacion(dr);

            return tip_pub;
        }


        // --> Paso una dataRow a un objeto TipoPublicacion
        private static TipoPublicacion dataRowToTipoPublicacion(DataRow dr)
        {

            return new TipoPublicacion(dr["Descripcion"].ToString(),Convert.ToInt32(dr["ID"]));
        }


        // --> Obtengo las publicaciones
        public static List<Publicacion> GetPublicaciones()
        {

            List<Publicacion> lstPublicaciones = new List<Publicacion>();
            DataTable tablePub = SqlConnector.retrieveDataTable("GetPublicaciones");

            foreach (DataRow dr in tablePub.Rows)
            {
                Publicacion pub = dataRowToPublicacion(dr);
                pub.Rubros = getRubrosFromPublicacion(pub);          
                lstPublicaciones.Add(pub);
            }
            
            return lstPublicaciones;
        }


        // --> Obtengo los rubros de una publicacion
        private static List<Rubro> getRubrosFromPublicacion(Publicacion pub)
        {

            DataTable tableRub = SqlConnector.retrieveDataTable("GetRubrosFromPublicacion", pub.ID);
            List<Rubro> rubros = new List<Rubro>();
            foreach (DataRow dr in tableRub.Rows)
            {
                Rubro rub = new Rubro(Convert.ToInt32(dr["ID"]), dr["Descripcion"].ToString());
                rubros.Add(rub);
            }

            return rubros;

        }


        // --> Paso una dataRow a un objeto Publicacion
        private static Publicacion dataRowToPublicacion(DataRow dr)
        {
            string strValSubasta = dr["Valor_Inicial_Subasta"].ToString();
            double valInSubasta;
            if (strValSubasta == null)
            {
                valInSubasta = Convert.ToDouble(strValSubasta);
            }
            else
            {
                valInSubasta = 0;
            }


            Publicacion publicacion = new Publicacion(Convert.ToInt32(dr["Id"]),
                    Convert.ToInt32(dr["Id_Visibilidad"]),
                    Convert.ToInt32(dr["Id_Tipo_Publicacion"]),
                    Convert.ToInt32(dr["Id_Estado"]),
                    Convert.ToInt32(dr["Id_Persona_Venta"]),
                    dr["Descripcion"].ToString(),
                    Convert.ToDateTime(dr["Fecha_Inicio"]),
                    Convert.ToDateTime(dr["Fecha_Vencimiento"]),
                    Convert.ToInt32(dr["Stock"]),
                    Convert.ToDouble(dr["Precio"]),
                    Convert.ToBoolean(dr["Hab_Preguntas"]), new List<Rubro>(),
                    valInSubasta);

            return publicacion;
        }

        public static void setPublicacion(Publicacion p)
        {

            executePublicacion("SetPublicacion", p);
        }

        public static void updatePublicacion(Publicacion p)
        {
            executePublicacion("UpdatePublicacion", p);
        }

        private static  void executePublicacion(string storeProcedure, Publicacion p)
        {
            SqlConnector.executeProcedure(storeProcedure, p.ID,
                                p.ID_Visibilidad, p.ID_Tipo_Publicacion, p.ID_Estado, p.ID_Persona,
                                p.Descripcion, p.Fecha_Inicio, p.Fecha_Vencimiento, p.Stock,
                                p.Precio, p.ValorInicialSubasta, p.Hab_Preguntas);
        }

        public static void setRubrosPublicacion(List<RubroPublicacion> lst)
        {
            foreach (RubroPublicacion rp in lst)
            {
                SqlConnector.executeProcedure("SetRubroPublicacion", rp.idPublicacion, rp.idRubro);
            }
        }

    }
}
