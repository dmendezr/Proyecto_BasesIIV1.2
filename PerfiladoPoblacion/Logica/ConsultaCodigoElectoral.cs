using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
   public class ConsultaCodigoElectoral
    {
        public static DataTable DevuelveCodElec()
        {
            return Datos.CodigoElectoral.ObtenerCodigoElectoral();
        }
    }
}
