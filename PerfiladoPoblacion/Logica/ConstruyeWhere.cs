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
        public void filtrarNombre (string nombre)
        {
            cadenaWhere += "Vot.Nombre ='" + nombre + "' and ";
        }
        public void filtrarApellido1 (string apellido1)
        {
            cadenaWhere += "Vot.Apellido1 ='" + apellido1 + "' and ";
        }
        public void filtrarApellido2(string apellido2)
        {
            cadenaWhere += "Vot.Apellido2 ='" + apellido2 + "' and ";
        }
        public void filtrarSexo(string sexo)
        {
            cadenaWhere += "Vot.Sexo ='" + sexo + "' and ";
        }
        public void filtrarFechaCaduc(string fechaCaduc)
        {
            cadenaWhere += "Vot.FechaCaduc ='" + fechaCaduc + "' and ";
        }
        public void filtrarJunta(string junta)
        {
            cadenaWhere += "Vot.Junta ='" + junta + "' and ";
        }
        public void filtrarDistrito(string distrito)
        {
            cadenaWhere += "codE.Distrito ='" + distrito + "' and ";
        }
        public void filtrarCanton(string canton)
        {
            cadenaWhere += "Cant.nombre ='" + canton + "' and ";
        }
        public void filtrarProvincia(string provincia)
        {
            cadenaWhere += "Prov.nombre ='" + provincia + "' and ";
        }
        public String devuelveCadena()
        {
            String cadenaDepurada = cadenaWhere.Substring(0, cadenaWhere.Length - 4);
            cadenaDepurada += " ";
            return cadenaDepurada;
        }
    }
}
