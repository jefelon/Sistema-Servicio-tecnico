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
       public class FIngreso
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

            };
            return DBHelper.ExecuteDataSet("usp_Datos_FIngreso_GetAll", dbParams);
        }
        public static DataSet NumeroIngresoDetalle(int numeroIngresoDetalle)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Numero",SqlDbType.Int,0,numeroIngresoDetalle),
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FDetalleProductoSalida_Get", dbParams);
        }
        public static DataSet Get(int numeroIngreso)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Numero",SqlDbType.Int,0,numeroIngreso),
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FIngreso_Get", dbParams);
        }
        public static int Insertar(Ingreso ingreso)
        {//Id, Numero, FechaIngreso, ObservacionExterna, ObservacionInterna, MotivoIngreso, FechaProbableReparacion, Adelanto, Estado, ClienteId, EquipoId
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@FechaIngreso",SqlDbType.DateTime,0,ingreso.FechaIngreso),
                DBHelper.MakeParam("@ObservacionExterna",SqlDbType.VarChar,0,ingreso.ObservacionExterna),
                DBHelper.MakeParam("@ObservacionInterna",SqlDbType.VarChar,0,ingreso.ObservacionInterna),
                DBHelper.MakeParam("@MotivoIngreso",SqlDbType.VarChar,0,ingreso.MotivoIngreso),
                DBHelper.MakeParam("@FechaProbableReparacion",SqlDbType.DateTime,0,ingreso.FechaProbableReparacion),
                DBHelper.MakeParam("@Adelanto",SqlDbType.Decimal,0,ingreso.Adelanto),
                DBHelper.MakeParam("@Estado",SqlDbType.VarChar,0,ingreso.Estado),
                DBHelper.MakeParam("@ClienteId",SqlDbType.Int,0,ingreso.Cliente.Id),
                DBHelper.MakeParam("@EquipoId",SqlDbType.Int,0,ingreso.Equipo.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FIngreso_Insertar", dbParams));
        }
        public static int Actualizar(Ingreso ingreso)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,ingreso.Id),
                DBHelper.MakeParam("@Numero",SqlDbType.Int,0,ingreso.Numero),
                DBHelper.MakeParam("@FechaIngreso",SqlDbType.DateTime,0,ingreso.FechaIngreso),
                DBHelper.MakeParam("@ObservacionExterna",SqlDbType.VarChar,0,ingreso.ObservacionExterna),
                DBHelper.MakeParam("@ObservaconInterna",SqlDbType.VarChar,0,ingreso.ObservacionInterna),
                DBHelper.MakeParam("@MotivoIngreso",SqlDbType.VarChar,0,ingreso.MotivoIngreso),
                DBHelper.MakeParam("@FechaProbableReparacion",SqlDbType.DateTime,0,ingreso.FechaProbableReparacion),
                DBHelper.MakeParam("@Adelanto",SqlDbType.Decimal,0,ingreso.Adelanto),
                DBHelper.MakeParam("@Estado",SqlDbType.VarChar,0,ingreso.Estado),
                DBHelper.MakeParam("@ClienteId",SqlDbType.Int,0,ingreso.Cliente.Id),
                DBHelper.MakeParam("@EquipoId",SqlDbType.Int,0,ingreso.Equipo.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FIngreso_Actualizar", dbParams));
        }
        public static int Eliminar(Ingreso ingreso)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,ingreso.Id)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FIngreso_Actualizar", dbParams));
        }
    }
}
