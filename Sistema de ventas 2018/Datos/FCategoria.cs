using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Sistema_de_ventas_2018.Negocio;

namespace Sistema_de_ventas_2018.Datos
{
    public class FCategoria
    {
        public static DataSet GetAll()//trae todos los datos
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {

                };
            return DBHelper.ExecuteDataSet("usp_Datos_FCategoria_GetAll", dbParams);//procedimiento de la base de daatos que trae todos los registros

        }

        public static int Insertar(Categoria categoria)//recibimos los parámetros como objeto de la capa entidad
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {       
                     DBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, categoria.Descripcion)
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FCategoria_Insertar", dbParams));//procedimiento de la base de daatos que inserta datos como escalr y no como data set los registros
            

        }

        public static int Actualizar(Categoria categoria)//recibimos los parámetros como objeto de la capa entidad
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Id", SqlDbType.Int, 0, categoria.Id),
                    DBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, categoria.Descripcion)
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FCategoria_Actualizar", dbParams));//procedimiento de la base de daatos que actualiza datos como escalr y no como data set los registros

        }

        public static int Eliminar(Categoria categoria)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    DBHelper.MakeParam("@Id", SqlDbType.Int, 0, categoria.Id), // es el id que quieramos para eliminar
                };
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_Datos_FCategoria_Eliminar", dbParams));//procedimiento de la base de daatos que elimina datos como escalar y no como data set los registros

        } 
    }
}
