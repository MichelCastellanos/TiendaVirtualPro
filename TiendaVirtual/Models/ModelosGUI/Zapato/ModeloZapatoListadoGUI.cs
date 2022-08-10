using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiendaVirtual.Models.ModelosGUI.Zapato
{
    public class ModeloZapatoListadoGUI 
    {
        private ModeloZapatoGUI zapato;

        public ModeloZapatoGUI Zapato
        {
            get { return zapato; }
            set { zapato = value; }
        }


        private IEnumerable<SelectListItem> listadoCategoria;

        public IEnumerable<SelectListItem> ListadoCategoria
        {
            get { return listadoCategoria; }
            set { listadoCategoria = value; }
        }

        private IEnumerable<SelectListItem> listadoMarca;

        public IEnumerable<SelectListItem> ListadoMarca
        {
            get { return listadoMarca; }
            set { listadoMarca = value; }
        }

        private IEnumerable<SelectListItem> listadoProveedor;

        public IEnumerable<SelectListItem> ListadoProveedor
        {
            get { return listadoProveedor; }
            set { listadoProveedor = value; }
        }
    }
}