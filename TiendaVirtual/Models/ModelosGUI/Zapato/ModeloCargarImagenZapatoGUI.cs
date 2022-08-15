using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaVirtual.Models.ModelosGUI.Zapato
{
    public class ModeloCargarImagenZapatoGUI
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private HttpPostedFileBase archivo;

        public HttpPostedFileBase Archivo
        {
            get { return archivo; }
            set { archivo = value; }
        }

    }
}