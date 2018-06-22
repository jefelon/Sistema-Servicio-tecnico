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
    public class FModelo
    {
       public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

            };
            return DBHelper.ExecuteDataSet("usp_Datos_FModelo_GetAll", dbParams);
        }
        public static int Insertar(Modelo modelo)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,modelo.Nombre)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FModelo_Insertar", dbParams));
        } 
        public static int Actualizar(Modelo modelo)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,modelo.Id),
                DBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,modelo.Nombre)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FModelo_Actualizar", dbParams));
        }
        public static int Eliminar(Modelo modelo)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id", SqlDbType.Int,0,modelo.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FModelo_Eliminar", dbParams));
        }
    }
}
