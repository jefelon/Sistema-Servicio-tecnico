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
       public class FStock
    {
       
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FStock_GetAll", dbParams);
        }
        public static int Insertar(Stock stock)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@ProductoId",SqlDbType.Int,0,stock.ProductoId.Id),
                DBHelper.MakeParam("@Stock",SqlDbType.Int,0,stock.CantidadStock)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FStock_Insertar", dbParams));
        }
        public static int Actualizar(Stock stock)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,stock.Id),
                DBHelper.MakeParam("@ProductoId",SqlDbType.Int,0,stock.ProductoId.Id),
                DBHelper.MakeParam("@Stock",SqlDbType.Int,0,stock.CantidadStock)
            };
             return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FStock_Actualizar", dbParams));
        }
    }
}
