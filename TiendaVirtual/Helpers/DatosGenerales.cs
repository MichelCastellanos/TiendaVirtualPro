using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TiendaVirtual.Helpers
{
    public class DatosGenerales
    {
        public static int RegistrosPorPagina = Int32.Parse(ConfigurationManager.AppSettings["NumeroRegistrosPagina"].ToString());
        public static string RutaCarpetaFotos = ConfigurationManager.AppSettings["RutaCarpetaFotos"];
    }
}