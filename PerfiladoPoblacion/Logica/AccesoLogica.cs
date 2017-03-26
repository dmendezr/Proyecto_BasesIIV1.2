using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class AccesoLogica
    {
        public static DataTable ObtenerPrivilegios()
        {
            return AccesoDatos.ObtenerPrivilegios();

        }
    }//fin
}
