using AccesoDeDatos.DbModel.Parametros;
using AccesoDeDatos.DbModel.Zapato;
using AccesoDeDatos.Implementacion.Zapatos;
using Logica.DTO.Parametros;
using Logica.DTO.Zapato;
using Logica.Mapeadores.Parametros;
using Logica.Mapeadores.Zapato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Implementacion.Zapato
{

    public class ImplZapatoLogica
    {
        private ImplZapatoDatos acceso;
        public ImplZapatoLogica()
        {
            this.acceso = new ImplZapatoDatos();
        }
        /// <summary>
        /// listar registros de marcas por la capa logica de negocio
        /// </summary>
        /// <param name="filtro">filtro a buscar</param>
        /// <param name="numeroPag">pagina actual</param>
        /// <param name="numeroRegistrosPagina">cantidad de registros a mostrar por pagina</param>
        /// <param name="totalRegistros">conteo de los registros totales en la base de datos</param>
        /// <returns></returns>
        public IEnumerable<ZapatoDTO> ListarRegistros(string filtro, int numeroPag, int numeroRegistrosPagina, out int totalRegistros)
        {
            var listado = this.acceso.ListarRegistros(filtro, numeroPag, numeroRegistrosPagina, out totalRegistros);
            MapeadorZapatoLogica mapeador = new MapeadorZapatoLogica();
            return mapeador.MapearTipo1Tipo2(listado);
        }
        /// <summary>
        /// buscar registro por la capa de negocio
        /// </summary>
        /// <param name="id">id necesario para la busqueda</param>
        /// <returns>un objeto tipo ZapatoDTO</returns>
        public ZapatoDTO BuscarRegistro(int id)
        {
            var listado = this.acceso.BuscarRegistro(id);
            MapeadorZapatoLogica mapeador = new MapeadorZapatoLogica();
            return mapeador.MapearTipo1Tipo2(listado);
        }
        /// <summary>
        /// verificar si guardo un registro
        /// </summary>
        /// <param name="registro">registro a guardar</param>
        /// <returns>una respuesta booleana sobre el guardado del registro</returns>
        public bool GuardarRegistro(ZapatoDTO registro)
        {
            MapeadorZapatoLogica mapeador = new MapeadorZapatoLogica();
            ZapatoDbModel marcaDB = mapeador.MapearTipo2Tipo1(registro);
            bool respuesta = this.acceso.GuardarRegistro(marcaDB);
            return respuesta;
        }
        /// <summary>
        /// editar un registro 
        /// </summary>
        /// <param name="registro">registro a editar</param>
        /// <returns>respuesta booleana si edito o no</returns>
        public bool EditarRegistro(ZapatoDTO registro)
        {
            MapeadorZapatoLogica mapeador = new MapeadorZapatoLogica();
            ZapatoDbModel marcaDB = mapeador.MapearTipo2Tipo1(registro);
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


        public IEnumerable<MarcaDTO> ListadoMarca()
        {
            var lista = this.acceso.ListadoMarca().ToList();
            MapeadorMarcaLogica mapeador = new MapeadorMarcaLogica();
            return mapeador.MapearTipo1Tipo2(lista);
        }
            
        

        public IEnumerable<CategoriaDTO> ListadoCategoria()
        {
            var lista = this.acceso.ListadoCategoria().ToList();
            MapeadorCategoriaLogica mapeador = new MapeadorCategoriaLogica();
            return mapeador.MapearTipo1Tipo2(lista);

        }

        public IEnumerable<ProveedorDTO> ListadoProveedor()
        {
            var lista = this.acceso.ListadoProveedor().ToList();
            MapeadorProveedorLogica mapeador = new MapeadorProveedorLogica();
            return mapeador.MapearTipo1Tipo2(lista);

        }

        public bool GuardarNombreFotoZapato(FotoZapatoDTO modelo)
        {
            MapeadorFotoZapatoLogica mapeador = new MapeadorFotoZapatoLogica();
            FotoZapatoDbModel fotoDb = mapeador.MapearTipo2Tipo1(modelo);
            bool respuesta = this.acceso.GuardarFotoZapato(fotoDb);
            return respuesta;
        }
    }

}
