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


        public static SqlCommand InsertDeVotante(string cedula, string codElec, string sexo, string fechaCaduc, string junta, string nombre, string apellido1, string apellido2, string usuario, string ip)
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("InsertDeVotante", _conexion);
            _comando.CommandTimeout = 0;
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add("@Cedula", SqlDbType.NVarChar).Value = cedula;
            _comando.Parameters.Add("@codElec", SqlDbType.NVarChar).Value = codElec;
            _comando.Parameters.Add("@sexo", SqlDbType.NVarChar).Value = sexo;
            _comando.Parameters.Add("@fechaCaduc", SqlDbType.NVarChar).Value = fechaCaduc;
            _comando.Parameters.Add("@junta", SqlDbType.NVarChar).Value = junta;
            _comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            _comando.Parameters.Add("@apellido1", SqlDbType.NVarChar).Value = apellido1;
            _comando.Parameters.Add("@apellido2", SqlDbType.NVarChar).Value = apellido2;
            _comando.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
            _comando.Parameters.Add("@ip", SqlDbType.NVarChar).Value = ip;
            return _comando;
        }

        public static SqlCommand insertBitacora(string Usuario, string ipOrigen, string consulta, string tabla)
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("AgregaBitacora", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = Usuario;
            _comando.Parameters.Add("@ipOrigen", SqlDbType.NVarChar).Value = ipOrigen;  
            _comando.Parameters.Add("@consulta", SqlDbType.NVarChar).Value = consulta;
            _comando.Parameters.Add("@tabla", SqlDbType.NVarChar).Value = tabla;
            return _comando;
        }



        public static SqlCommand ModificacionVotante(string cedula, string codElec, string sexo, string fechaCaduc, string junta, string nombre, string apellido1, string apellido2,string usuario, string ip)
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("ModificarVotante", _conexion);
            _comando.CommandTimeout = 0;
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add("@Cedula", SqlDbType.NVarChar).Value = cedula;
            _comando.Parameters.Add("@codElec", SqlDbType.NVarChar).Value = codElec;
            _comando.Parameters.Add("@sexo", SqlDbType.NVarChar).Value = sexo;
            _comando.Parameters.Add("@fechaCaduc", SqlDbType.NVarChar).Value = fechaCaduc;
            _comando.Parameters.Add("@junta", SqlDbType.NVarChar).Value = junta;
            _comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            _comando.Parameters.Add("@apellido1", SqlDbType.NVarChar).Value = apellido1;
            _comando.Parameters.Add("@apellido2", SqlDbType.NVarChar).Value = apellido2;
            _comando.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
            _comando.Parameters.Add("@ip", SqlDbType.NVarChar).Value = ip;
            return _comando;
        }

        public static SqlCommand EliminarVotante(string cedula,string usuario, string ip)
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("EliminarVotante", _conexion);
            _comando.CommandTimeout = 0;
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add("@Cedula", SqlDbType.NVarChar).Value = cedula;
            _comando.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
            _comando.Parameters.Add("@ip", SqlDbType.NVarChar).Value = ip;
            return _comando;
        }

        public static DataTable ConsultaVotante(String cedula)
        {
            try
            {
                DataTable dt = new DataTable();
                string _cadenaConexion = Configuracion.CadenaConexion;
                SqlConnection _conexion = new SqlConnection();
                _conexion.ConnectionString = _cadenaConexion;
                SqlDataAdapter da = new SqlDataAdapter("BuscarVotante",_conexion);
                _conexion.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@cedula", SqlDbType.NVarChar).Value = cedula;
                da.Fill(dt);
                _conexion.Dispose();
                _conexion.Close();
                return dt;
            }
            catch { throw; }
        }


        public static int EjecutarProcedimientoAlmacenado(SqlCommand comando)
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

        public static SqlCommand InsertCanton(string codCanton, string nombre)
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("InsertarCanton", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;          
            _comando.Parameters.Add("@codCanton", SqlDbType.NVarChar).Value = codCanton;
            _comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;

            return _comando;
        }

        public static DataTable ConsultaCanton(String codCanton)
        {
            try
            {
                DataTable dt = new DataTable();
                string _cadenaConexion = Configuracion.CadenaConexion;
                SqlConnection _conexion = new SqlConnection();
                _conexion.ConnectionString = _cadenaConexion;
                SqlDataAdapter da = new SqlDataAdapter("BuscarCanton", _conexion);
                _conexion.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@codCanton", SqlDbType.NVarChar).Value = codCanton;
                da.Fill(dt);
                _conexion.Dispose();
                _conexion.Close();
                return dt;
            }
            catch { throw; }
        }


        public static SqlCommand ModificarCanton(string codCanton, string nombre)
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("ModificarCanton", _conexion);
            _comando.CommandTimeout = 0;
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add("@codCanton", SqlDbType.NVarChar).Value = codCanton;
            _comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
           
            return _comando;
        }

        public static SqlCommand InsertarDistrito(string CodElec, string CodProvincia, string CodCanton, string Distrito)
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("InsertarDistrito", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add("@Cod_Elec", SqlDbType.NVarChar).Value = CodElec;
            _comando.Parameters.Add("@codProvincia", SqlDbType.NVarChar).Value = CodProvincia;
            _comando.Parameters.Add("@codCanton", SqlDbType.NVarChar).Value = CodCanton;
            _comando.Parameters.Add("@Distrito", SqlDbType.NVarChar).Value = Distrito;


            return _comando;
        }

        public static DataTable BuscarDistrito (String codElec)
        {
            try
            {
                DataTable dt = new DataTable();
                string _cadenaConexion = Configuracion.CadenaConexion;
                SqlConnection _conexion = new SqlConnection();
                _conexion.ConnectionString = _cadenaConexion;
                SqlDataAdapter da = new SqlDataAdapter("BuscarDistrito", _conexion);
                _conexion.Open();
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@CodElec", SqlDbType.NVarChar).Value = codElec;
                da.Fill(dt);
                _conexion.Dispose();
                _conexion.Close();
                return dt;
            }
            catch { throw; }
        }

        public static SqlCommand ModificarDistrito(string codElec, string codProvincia, string codCanton, string Distrito)
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("ModificarDistrito", _conexion);
            _comando.CommandTimeout = 0;
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add("@CodElec", SqlDbType.NVarChar).Value = codElec;
            _comando.Parameters.Add("@codProvincia", SqlDbType.NVarChar).Value = codProvincia;
            _comando.Parameters.Add("@codCanton", SqlDbType.NVarChar).Value = codCanton;
            _comando.Parameters.Add("@Distrito", SqlDbType.NVarChar).Value = Distrito;
       
            return _comando;
        }
        public static SqlCommand InsertarUsuario(string idUsuario,string cedula, string idRol, string usuario, string contrasena)
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("InsertarUsuario", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add("@idUsuario", SqlDbType.NVarChar).Value = idUsuario;
            _comando.Parameters.Add("@cedula", SqlDbType.NVarChar).Value = cedula;
            _comando.Parameters.Add("@IdRol", SqlDbType.NVarChar).Value = idRol;
            _comando.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
            _comando.Parameters.Add("@contrasena", SqlDbType.NVarChar).Value = contrasena;


            return _comando;
        }

    }//fin SqlCommand
}
