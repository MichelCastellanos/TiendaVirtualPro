using AccesoDeDatos.DbModel;
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
    public class ImplMarcaLogica
    {
        private ImplMarcaDatos acceso;
        public ImplMarcaLogica()
        {
            this.acceso = new ImplMarcaDatos();
        }
        /// <summary>
        /// listar registros de marcas por la capa logica de negocio
        /// </summary>
        /// <param name="filtro">filtro a buscar</param>
        /// <param name="numeroPag">pagina actual</param>
        /// <param name="numeroRegistrosPagina">cantidad de registros a mostrar por pagina</param>
        /// <param name="totalRegistros">conteo de los registros totales en la base de datos</param>
        /// <returns></returns>
        public IEnumerable<MarcaDTO> ListarRegistros(string filtro, int numeroPag, int numeroRegistrosPagina, out int totalRegistros)
        {
            var listado = this.acceso.ListarRegistros(filtro, numeroPag, numeroRegistrosPagina, out totalRegistros);
            MapeadorMarcaLogica mapeador = new MapeadorMarcaLogica();
            return mapeador.MapearTipo1Tipo2(listado);
         }
        /// <summary>
        /// buscar registro por la capa de negocio
        /// </summary>
        /// <param name="id">id necesario para la busqueda</param>
        /// <returns>un objeto tipo MarcaDTO</returns>
        public MarcaDTO BuscarRegistro(int id)
        {
            var listado = this.acceso.BuscarRegistro(id);
            MapeadorMarcaLogica mapeador = new MapeadorMarcaLogica();
            return mapeador.MapearTipo1Tipo2(listado);
        }
        /// <summary>
        /// verificar si guardo un registro
        /// </summary>
        /// <param name="registro">registro a guardar</param>
        /// <returns>una respuesta booleana sobre el guardado del registro</returns>
        public bool GuardarRegistro(MarcaDTO registro)
        {
            MapeadorMarcaLogica mapeador = new MapeadorMarcaLogica();
            MarcaDbModel marcaDB = mapeador.MapearTipo2Tipo1(registro);
            bool respuesta = this.acceso.GuardarRegistro(marcaDB);
            return respuesta;
        }
        /// <summary>
        /// editar un registro 
        /// </summary>
        /// <param name="registro">registro a editar</param>
        /// <returns>respuesta booleana si edito o no</returns>
        public bool EditarRegistro(MarcaDTO registro)
        {
            MapeadorMarcaLogica mapeador = new MapeadorMarcaLogica();
            MarcaDbModel marcaDB = mapeador.MapearTipo2Tipo1(registro);
            bool respuesta = this.acceso.EditarRegistro(marcaDB);
            return respuesta;
        }
        /// <summary>
        /// borrar un registro
        /// </summary>
        /// <param name="id">id del registro para ser borrado</param>
        /// <returns>respuesta booleana si elimino o no</returns>
        public bool BorrarRegistro(int id)
        {
            bool respuesta = this.acceso.BorrarRegistro(id);
            return respuesta;
        }
    }
}
