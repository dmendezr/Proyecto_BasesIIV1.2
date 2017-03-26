using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ConstruyeWhere
    {
        private String cadenaWhere { get; set; }

        public void main ()
        {

        }

        public  void filtraCedula(string cedula)
        {
            cadenaWhere += "Vot.Cedula =" + cedula + " and ";
        }

        public String devuelveCadena()
        {
            String cadenaDepurada = cadenaWhere.Substring(0, cadenaWhere.Length - 4);
            cadenaDepurada += " ";
            return cadenaDepurada;
        }
    }
}
