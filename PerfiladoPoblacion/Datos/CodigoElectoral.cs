﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CodigoElectoral
    {
        public static DataTable ObtenerCodigoElectoral()
        {
            return MetodosDatos.EjecutaProcedimientoSelect("BuscarCodElec");
        }

    }
}
