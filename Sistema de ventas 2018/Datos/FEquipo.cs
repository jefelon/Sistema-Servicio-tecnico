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
    public class FEquipo
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

            };
            return DBHelper.ExecuteDataSet("usp_Datos_FEquipo_GetAll", dbParams);
        }
        public static int Insertar(Equipo equipo)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Descripcion", SqlDbType.VarChar,0,equipo.Descripcion),
                DBHelper.MakeParam("@ModeloId", SqlDbType.Int,0,equipo.Modelo.Id),
                DBHelper.MakeParam("@Serie", SqlDbType.VarChar,0,equipo.Serie),
                DBHelper.MakeParam("@MarcaId",SqlDbType.Int,0,equipo.Marca.Id)                
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FEquipo_Insertar", dbParams));
        }
        public static int Actualizar(Equipo equipo)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
               DBHelper.MakeParam("@Id",SqlDbType.Int, 0, equipo.Id),
               DBHelper.MakeParam("@Descripcion", SqlDbType.VarChar,0,equipo.Descripcion),
               DBHelper.MakeParam("@ModeloId", SqlDbType.Int,0,equipo.Modelo.Id),
               DBHelper.MakeParam("@Serie", SqlDbType.VarChar,0,equipo.Serie),
               DBHelper.MakeParam("@MarcaId",SqlDbType.Int,0,equipo.Marca.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FEquipo_Actualizar", dbParams));
        }
        public static int Eliminar(Equipo equipo)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,equipo.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FEquipo_Eliminar", dbParams));
        }
    }
}
