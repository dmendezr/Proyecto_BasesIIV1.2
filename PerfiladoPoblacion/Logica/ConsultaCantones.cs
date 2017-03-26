using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class ConsultaCantones
    {
        public static DataTable DevuelveCanton()
        {
            return Datos.Canton.ObtenerCanton();
        }
    }
}
