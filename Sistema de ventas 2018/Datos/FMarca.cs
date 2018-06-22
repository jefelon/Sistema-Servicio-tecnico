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
    public class FMarca
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

            };
        return DBHelper.ExecuteDataSet("usp_Datos_FMarca_GetAll", dbParams);
        }
        public static int Insertar(Marca marca)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,marca.Nombre)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FMarca_Insertar", dbParams));
        }
        public static int Actualizar(Marca marca)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,marca.Id),
                DBHelper.MakeParam("@Nombre",SqlDbType.VarChar,0,marca.Nombre)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FMarca_Actualizar", dbParams));
         }
        public static int Eliminar(Marca marca)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,marca.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FMarca_Eliminar", dbParams));
        }
     }
}
