using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiendaVirtual.Models.ModelosGUI.Zapato
{
    public class ModeloFotoZapatoGUI
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombreFoto;

        public string NombreFoto
        {
            get { return nombreFoto; }
            set { nombreFoto = value; }
        }

        private int id_Vehiculo;

        public int Id_Vehiculo
        {
            get { return id_Vehiculo; }
            set { id_Vehiculo = value; }
        }

    }
}