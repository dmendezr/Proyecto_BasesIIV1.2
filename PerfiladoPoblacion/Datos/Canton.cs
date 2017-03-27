using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Canton
    {
        public static DataTable ObtenerCanton ()
        {
            return MetodosDatos.EjecutaProcedimientoSelect("ConsultaCantones");
        }

        public static int InsertCanton(string codCanton, string nombre)
        {
            SqlCommand _comando = MetodosDatos.InsertCanton(nombre, codCanton);

            return MetodosDatos.EjecutarProcedimientoAlmacenado(_comando);
        }

        public static DataTable BuscarCanton(string codCanton)
        {
            return MetodosDatos.ConsultaCanton(codCanton);
        }

        public static int ModificarCanton(string codCanton, string nombre)
        {
            SqlCommand _comando = MetodosDatos.ModificarCanton(codCanton, nombre);
            return MetodosDatos.EjecutarProcedimientoAlmacenado(_comando);
        }
    }

   
}
