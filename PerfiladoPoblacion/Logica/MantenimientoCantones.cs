using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

using System.Threading.Tasks;


namespace Logica
{
    public class MantenimientoCantones
    {
        public static int InsertDeCantones(string codElec, string nombre)
        {
            return Datos.Canton.InsertCanton(codElec, nombre);
        }
        public static DataTable BuscarCanton(string codCanton)
        {
            return Datos.Canton.BuscarCanton(codCanton);
        }

        public static int ModificarCanton(string codCanton, string nombre)
        {
            return Datos.Canton.ModificarCanton(codCanton, nombre);
        }

    }
}
