using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class AccesoDatos
    {
        public static DataTable ObtenerPrivilegios()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM Privilegios";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }
    }
}
