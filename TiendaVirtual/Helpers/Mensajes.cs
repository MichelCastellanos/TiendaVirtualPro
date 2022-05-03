using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TiendaVirtual.Helpers
{
    public static class Mensajes
    {
        public static string MensajeErrorBorrar = ConfigurationManager.AppSettings["MensajeErrorAlEliminar"];
        public static string MensajeEdicionCorrecta = ConfigurationManager.AppSettings["MensajeEdicionExitosa"];

    }
}