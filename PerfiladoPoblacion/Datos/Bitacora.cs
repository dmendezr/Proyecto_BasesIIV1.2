using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Bitacora
    {
        public static int InsertarBitacora(string Usuario, string ipOrigen, string consulta, string tabla)
        {
            SqlCommand _comando = MetodosDatos.insertBitacora(Usuario,ipOrigen,consulta,tabla);
            return MetodosDatos.EjecutarProcedimientoAlmacenado(_comando);
        }
    }
}
