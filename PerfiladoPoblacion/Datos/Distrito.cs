using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class Distrito
    {
        public static DataTable obtenerDistritos()
        {
            return MetodosDatos.EjecutaProcedimientoSelect("ConsultaDistritos");
        }
        public static int InsertarDistrito(string codElec, string codProvincia,string codCanton, string Distrito)
        {
            SqlCommand _comando = MetodosDatos.InsertarDistrito(codElec,codProvincia, codCanton,Distrito);

            return MetodosDatos.EjecutarProcedimientoAlmacenado(_comando);
        }
        public static DataTable BuscarDistrito(string codElec)
        {
            return MetodosDatos.BuscarDistrito(codElec);
        }

        public static int ModificarDistrito(string codElec, string codProvincia, string codCanton,string Distrito)
        {
            SqlCommand _comando = MetodosDatos.ModificarDistrito(codElec, codProvincia, codCanton, Distrito);
            return MetodosDatos.EjecutarProcedimientoAlmacenado(_comando);
        }

    }
}
