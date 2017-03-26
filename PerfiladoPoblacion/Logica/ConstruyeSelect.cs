using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logica
{
    
   public class ConstruyeSelect
    {
        private String cadenaSELECT { get; set; }
        public void main() {

        }

        public  void devuelveCedula()
        {
            cadenaSELECT += " Vot.Cedula as Cedula,";
            
        }

        public void devuelveNombre()
        {
            cadenaSELECT += " Vot.Nombre as Nombre,";
            
        }

        public void devuelveCodElec()
        {
            cadenaSELECT += " Vot.CodElec as 'Codigo Electoral',";
        }

        public void devuelveSexo()
        {
            cadenaSELECT += " Vot.Sexo as 'Sexo',";
        }

        public void devuelveFechaCaduc()
        {
            cadenaSELECT += " Vot.FechaCaduc as 'Fecha de Caducidad',";
        }
        
        public void devuelveJunta()
        {
            cadenaSELECT += "Vot.Junta as 'Junta',";
        }

        public void devuelvePrimerApellido()
        {
            cadenaSELECT += "Vot.Apellido1 as 'Primer Apellido',";
        }

        public void devuelveSegundoApellido()
        {
            cadenaSELECT += "Vot.Apellido2 as 'Segundo Apellido',";
        }
        
       /* public void devuelveEdad()
        {
            cadenaSELECT += "Vot.Edad as 'Edad',";
        }*/
        public void devuelveProvincia()
        {
            cadenaSELECT += "Prov.nombre as 'Provincia',";
        }
        
        public void devuelveCanton()
        {
            cadenaSELECT += "Cant.nombre as 'Canton',";
        }
        public void devuelveDistrito()
        {
            cadenaSELECT += "codE.Distrito as 'Distrito',";
        }

        public String devuelveCadena()
        {
            String cadenaDepurada = cadenaSELECT.Substring(0, cadenaSELECT.Length - 1);
            cadenaDepurada += " ";
            return cadenaDepurada;
        }

    }
}
