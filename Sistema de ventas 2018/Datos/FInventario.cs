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
       public class FInventario
    {
        public static DataSet GetAll()
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {

            };
            return DBHelper.ExecuteDataSet("usp_Datos_FInventario_GetAll", dbParams);
        }
        public static int Insertar(Inventario inventario)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@ProductoId",SqlDbType.Int,0,inventario.Producto.Id),
                DBHelper.MakeParam("@Entrada",SqlDbType.Int,0,inventario.Entrada),
                DBHelper.MakeParam("@Salida",SqlDbType.Int,0,inventario.Salida),
                DBHelper.MakeParam("@DetalleVentaId",SqlDbType.Int,0,inventario.DetalleVentaId),
                DBHelper.MakeParam("@DetalleCompraId",SqlDbType.Int,0,inventario.DetalleCompraId)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FInventario_Insertar", dbParams));
        }
        public static int Actualizar(Inventario inventario)
        {
            SqlParameter[] dbParams = new SqlParameter[]
            {
                DBHelper.MakeParam("@Id",SqlDbType.Int,0,inventario.Id),
                DBHelper.MakeParam("@ProductoId",SqlDbType.Int,0,inventario.Producto.Id),
                DBHelper.MakeParam("@Entrada",SqlDbType.Int,0,inventario.Entrada),
                DBHelper.MakeParam("@Salida",SqlDbType.Int,0,inventario.Salida),
                DBHelper.MakeParam("@Stock",SqlDbType.Int,0,inventario.Stock),
                DBHelper.MakeParam("@DetalleVentaId",SqlDbType.Int,0,inventario.DetalleVentaId),
                DBHelper.MakeParam("@DetalleCompraId",SqlDbType.Int,0,inventario.DetalleCompraId)
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FInventario_Actualizar", dbParams));
        }
    }
}
