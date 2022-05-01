using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TiendaVirtual.Models.ModelosTiendaVirtualGUI.Parametros
{
    public class ModeloMarcaGUI
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int nombre;

        [Required]
        [MinLength(3)]
        public int Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}