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
       public class FDetalleServicioSalida
    {
        public static DataSet GetAll(int salidaId)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@SalidaId",SqlDbType.Int,0,salidaId)
            };
            return DBHelper.ExecuteDataSet("usp_Datos_FDetalleServicioSalida_GetAll", dbParams);
        }
        public static int Insertar(DetalleServicioSalida detalleserviciosalida)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@SalidaId",SqlDbType.Int,0,detalleserviciosalida.Salida.Id),
                DBHelper.MakeParam("@ServicioId",SqlDbType.Int,0,detalleserviciosalida.Servicio.Id),
                DBHelper.MakeParam("@Precio",SqlDbType.Decimal,0,detalleserviciosalida.Precio),
                DBHelper.MakeParam("@Cantidad",SqlDbType.Decimal,0,detalleserviciosalida.Cantidad)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FDetalleServicioSalida_Insertar", dbParams));
        }
        public static int Actualizar(DetalleServicioSalida detalleserviciosalida)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,detalleserviciosalida.Id),
                DBHelper.MakeParam("@SalidaId",SqlDbType.Int,0,detalleserviciosalida.Salida.Id),
                DBHelper.MakeParam("@ServicioId",SqlDbType.Int,0,detalleserviciosalida.Servicio.Id),
                DBHelper.MakeParam("@Precio",SqlDbType.Decimal,0,detalleserviciosalida.Precio),
                DBHelper.MakeParam("@Cantidad",SqlDbType.Decimal,0,detalleserviciosalida.Cantidad)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FDetalleServicioSalida_Actualizar", dbParams));
        }
        public static int Eliminar(DetalleServicioSalida detalleserviciosalida)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,detalleserviciosalida.Id),
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FDetalleServicioSalida_Eliminar", dbParams));
        }
    }
}
