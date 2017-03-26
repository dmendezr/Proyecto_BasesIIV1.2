using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Datos
{
    class MetodosDatos
    {
        public static SqlCommand CrearComando()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;
        }

        public static SqlCommand CrearComandoProc()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("InsDatos", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }

        public static int EjecutarComandoInsert(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        public static DataTable EjecutaProcedimientoSelect(String nombreProcedure)
        {
            try
            {
                DataTable dt = new DataTable();
                string _cadenaConexion = Configuracion.CadenaConexion;
                SqlConnection _conexion = new SqlConnection();
                _conexion.ConnectionString = _cadenaConexion;
                SqlDataAdapter da = new SqlDataAdapter(nombreProcedure, _conexion);
                _conexion.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                _conexion.Dispose();
                _conexion.Close();
                return dt;
            }
            catch { throw; }
        }

        public static DataTable EjecutaProcedimientoSelectLogin(String nombreProcedure,String usuario, String contrasena )
        {
            try
            {
                DataTable dt = new DataTable();
                string _cadenaConexion = Configuracion.CadenaConexion;
                SqlConnection _conexion = new SqlConnection();
                _conexion.ConnectionString = _cadenaConexion;
                SqlDataAdapter da = new SqlDataAdapter(nombreProcedure, _conexion);
                _conexion.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
                da.SelectCommand.Parameters.Add("@contrasena", SqlDbType.NVarChar).Value = contrasena;
                da.Fill(dt);
                _conexion.Dispose();
                _conexion.Close();
                return dt;
            }
            catch { throw; }
        }

        public static DataTable EjecutaProcedimientoTraeLogin(String nombreProcedure, String usuario)
        {
            try
            {
                DataTable dt = new DataTable();
                string _cadenaConexion = Configuracion.CadenaConexion;
                SqlConnection _conexion = new SqlConnection();
                _conexion.ConnectionString = _cadenaConexion;
                SqlDataAdapter da = new SqlDataAdapter(nombreProcedure, _conexion);
                _conexion.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
                da.Fill(dt);
                _conexion.Dispose();
                _conexion.Close();
                return dt;
            }
            catch { throw; }
        }

        public static DataTable EjecutarComandoSelect(SqlCommand comando)
        {
            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
            }
            catch (Exception ex)
            { throw new Exception ("Fallo en la Conexion", ex); }
            finally
            { comando.Connection.Close(); }
            return _tabla;
        }

    }//fin SqlCommand
}
