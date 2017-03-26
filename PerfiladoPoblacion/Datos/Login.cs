using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Login
    {
        public static DataTable ObtenerLogin(string usuario, string contrasena)
        {
            return MetodosDatos.EjecutaProcedimientoSelectLogin("CompruebaLogin",usuario,contrasena);
        }

        public static DataTable ObtenerDatosLogin (string usuario)
        {
            return MetodosDatos.EjecutaProcedimientoTraeLogin("enviarLogin", usuario);
        }
    }
}
