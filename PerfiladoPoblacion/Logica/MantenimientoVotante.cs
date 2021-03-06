﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MantenimientoVotante
    {
        public static int InsertDeVotante(string cedula, string codElec, string sexo, string fechaCaduc, string junta, string nombre, string apellido1, string apellido2,string usuario)
        {
            string ip = obtieneDireccionIP.DevuelveIP();
            return Datos.Votante.InsertarVotante(cedula, codElec, sexo, fechaCaduc, junta, nombre, apellido1, apellido2,usuario,ip);
        }

        public static int ModificacionVotante(string cedula, string codElec, string sexo, string fechaCaduc, string junta, string nombre, string apellido1, string apellido2,string usuario)
        {
            string ip = obtieneDireccionIP.DevuelveIP();
            return Datos.Votante.ModificarVotante(cedula, codElec, sexo, fechaCaduc, junta, nombre, apellido1, apellido2,usuario,ip);
        }

        public static int EliminacionVotante(string cedula,string usuario)
        {
            string ip = obtieneDireccionIP.DevuelveIP();
            return Datos.Votante.EliminaVotante(cedula,usuario,ip);
        }
    }
}
