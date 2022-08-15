using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.DbModel.Zapato
{
    public class FotoZapatoDbModel
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

        private int id_Zapato;

        public int Id_Zapato
        {
            get { return id_Zapato; }
            set { id_Zapato = value; }
        }
    }
}
