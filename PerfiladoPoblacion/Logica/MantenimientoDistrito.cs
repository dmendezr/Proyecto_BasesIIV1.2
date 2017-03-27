using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;


namespace Logica
{
   public  class MantenimientoDistrito
    {
        public static int InsertarDistrito(string codElec, string codProvincia, string codCanton, string Distrito)
        {
            return Datos.Distrito.InsertarDistrito(codElec, codProvincia, codCanton,Distrito);
        }

        public static DataTable BuscarDistrito(string codElec)
        {
            return Datos.Distrito.BuscarDistrito(codElec);
        }
    }
}
