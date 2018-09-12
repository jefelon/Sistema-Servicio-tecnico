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
     public class FSalida
    {//Id, Numero, FechaSalida, Diagnostico, Estado
       public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

            };
            return DBHelper.ExecuteDataSet("usp_Datos_FSalida_GetAll", dbParams);
        }
        public static int Insertar(Salida salida)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Numero",SqlDbType.Int,0,salida.Numero),
                DBHelper.MakeParam("@FechaSalida",SqlDbType.DateTime,0,salida.FechaSalida),
                DBHelper.MakeParam("@Diagnostico",SqlDbType.VarChar,0,salida.Diagnostico),
                DBHelper.MakeParam("@Estado",SqlDbType.VarChar,0,salida.Estado),
                DBHelper.MakeParam("@IngresoId",SqlDbType.VarChar,0,salida.Ingreso.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FSalida_Insertar", dbParams));
        }
        public static int Actualizar(Salida salida)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,salida.Id),
                DBHelper.MakeParam("@Numero",SqlDbType.Int,0,salida.Numero),
                DBHelper.MakeParam("@FechaSalida",SqlDbType.DateTime,0,salida.FechaSalida),
                DBHelper.MakeParam("@Diagnostico",SqlDbType.VarChar,0,salida.Diagnostico),
                DBHelper.MakeParam("@Estado",SqlDbType.VarChar,0,salida.Estado)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FSalida_Actualizar", dbParams));
        }
        public static int Eliminar(Salida salida)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,salida.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FSalida_Eliminar", dbParams));
        }

        public static DataSet Get(int IngresoId)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@IngresoId",SqlDbType.Int,0,IngresoId),
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FSalida_Get", dbParams);
        }
        public static DataSet GetEstados(DateTime desde, DateTime hasta, string estado)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Desde",SqlDbType.Date,0,desde),
                DBHelper.MakeParam("@Hasta",SqlDbType.Date,0,hasta),
                DBHelper.MakeParam("@Estado",SqlDbType.VarChar,0,estado),
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FSalida_GetEstados", dbParams);
        }
    }
}
