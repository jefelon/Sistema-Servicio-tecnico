using Sistema_de_ventas_2018.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_ventas_2018.Datos
{
    class FUnidadMedida
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams= new SqlParameter[]
            {

            };
            return DBHelper.ExecuteDataSet("usp_Datos_FUnidadMedida_GetAll", dbParams);
        }
        public static int Insertar(UnidadMedida unidadmedida)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,unidadmedida.Nombre)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FUnidadMedida_Insertar", dbParams));
        }

        public static int Actualizar(UnidadMedida unidadmedida)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id", SqlDbType.Int, 0, unidadmedida.Id),
                DBHelper.MakeParam("@Nombre", SqlDbType.VarChar,0, unidadmedida.Nombre)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FUnidadMedida_Actualizar", dbParams));
         }
        public static int Eliminar(UnidadMedida unidadmedida)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,unidadmedida.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FUnidadMedida_Eliminar", dbParams));
        }
        
    }
}
