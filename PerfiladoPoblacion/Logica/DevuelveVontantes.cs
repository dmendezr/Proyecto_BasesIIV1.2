using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Logica
{
    public class DevuelveVotante
    {
        public static DataTable DevuelveVotantes(String DatosSelect, String DatosWhere)
        {
            return Votante.ObtenerVotante(DatosSelect, DatosWhere);
        }
    }
    
}
