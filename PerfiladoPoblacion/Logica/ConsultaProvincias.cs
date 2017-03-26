using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Logica
{
    public class ConsultaProvincias
    {
        public static DataTable DevuelveProvincias()
        {
            return Datos.Provincia.ObtenerProvincia();
        }
    }
}
