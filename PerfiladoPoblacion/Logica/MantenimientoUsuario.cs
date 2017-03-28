using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class MantenimientoUsuario
    {
        public static int InsertarUsuario(string idUsuario, string cedula, string idRol, string Usuario,string contrasena)
        {
            return Datos.Usuariocs.InsertaUsuario(idUsuario, cedula, idRol, Usuario, contrasena);
        }
    }
}
