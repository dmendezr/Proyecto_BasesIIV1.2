using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class ConsultaLogin
    {
        public static DataTable obtenerLogin (string usuario, string contrasena)
        {
            return Datos.Login.ObtenerLogin(usuario, contrasena);
        }
        
        public static DataTable obtenerDatosLogin (string usuario)
        {
            return Datos.Login.ObtenerDatosLogin(usuario);
        }
    }
}
