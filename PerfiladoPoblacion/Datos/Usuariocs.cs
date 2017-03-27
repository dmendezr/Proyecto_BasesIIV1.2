using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
   public class Usuariocs
    {
        public static int InsertaUsuario(string idUsuario, string cedula, string idRol, string usuario, string contrasena)
        {
            SqlCommand _comando = MetodosDatos.InsertarUsuario(idUsuario,cedula,idRol,usuario,contrasena);

            return MetodosDatos.EjecutarProcedimientoAlmacenado(_comando);
        }

    }
}
