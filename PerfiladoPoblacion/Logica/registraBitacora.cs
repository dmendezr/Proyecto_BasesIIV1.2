using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class registraBitacora
    {
        public static int registraBitac(string Usuario, string ipOrigen, string consulta,string tabla)
        {
            return Datos.Bitacora.InsertarBitacora(Usuario, ipOrigen, consulta, tabla);
        }
    }
}
