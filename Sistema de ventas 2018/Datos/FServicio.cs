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
    public class FServicio
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

            };
            return DBHelper.ExecuteDataSet("usp_Datos_FServicio_GetAll", dbParams);
        }
        public static int Insertar(Servicio servicio)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Descripcion",SqlDbType.VarChar,0,servicio.Descripcion),
                DBHelper.MakeParam("@Precio",SqlDbType.Decimal,0,servicio.Precio)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FServicio_Insertar", dbParams));
        }
        public static int Actualizar(Servicio servicio)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
            DBHelper.MakeParam("@Id",SqlDbType.Int,0,servicio.Id),
            DBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, servicio.Descripcion),
            DBHelper.MakeParam("@Precio", SqlDbType.Decimal, 0, servicio.Precio)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FServicio_Actualizar", dbParams));
        }
        public static int Eliminar(Servicio servicio)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                
            DBHelper.MakeParam("@Id",SqlDbType.Int,0,servicio.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FServicio_Eliminar", dbParams));
        }
    }
}
