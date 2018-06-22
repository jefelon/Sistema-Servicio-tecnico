using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_ventas_2018.Negocio;

namespace Sistema_de_ventas_2018.Datos
{
    public class FTipoDocumento
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
             };
            return DBHelper.ExecuteDataSet("usp_Datos_FTipoDocumento_GetAll", dbParams);
        }
        public static int Insertar(TipoDocumento tipodocumento)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, tipodocumento.Nombre),
                DBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, tipodocumento.Descripcion)
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FTipoDocumento_Insertar", dbParams));
        }
        public static int Actualizar(TipoDocumento tipodocumento)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int, 0, tipodocumento.Id),
                DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, tipodocumento.Nombre),
                DBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, tipodocumento.Descripcion)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FTipoDocumento_Actualizar", dbParams));
          }
        public static int Eliminar(TipoDocumento tipodocumento)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id", SqlDbType.Int,0,tipodocumento.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FTipoDocumento_Eliminar", dbParams));
        }
    }
}
