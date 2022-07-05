using AccesoDeDatos.Implementacion.Parametros;
using Logica.DTO.Parametros;
using Logica.Mapeadores.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Implementacion.Parametros
{
    public class ImplProveedorLogica
    {
        private ImplProveedorDatos acceso;
        public ImplProveedorLogica()
        {
            this.acceso = new ImplProveedorDatos();
        }
       
    }
}
