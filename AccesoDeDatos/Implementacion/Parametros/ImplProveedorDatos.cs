using AccesoDeDatos.DbModel.Parametros;
using AccesoDeDatos.Mapeadores.Parametros;
using AccesoDeDatos.modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.Implementacion.Parametros
{
    public class ImplProveedorDatos
    {
        /// <summary>
        /// metodo para listar registros
        /// </summary>
        /// <param name="filtro">filtro a aplicar</param>
        /// <returns></returns>
        /// <summary>
        /// metodo para listar registros
        /// </summary>
        /// <param name="filtro">filtro a aplicar</param>
        /// <returns></returns>
        public IEnumerable<ProveedorDbModel> ListarRegistros(String filtro, int PaginaActual, int numeroRegistroPagina, out int totalRegistros)
        {
            var lista = new List<ProveedorDbModel>();
            using (EllaYelDBEntities db = new EllaYelDBEntities())
            {
                // pag 1 = 1-10
                // pag 2 = 11-20
                // pag 3 = 21-30
                // pag 1 = 31-40
                // pag 1 = 41-50
                int registrosDescartados = (PaginaActual - 1) * numeroRegistroPagina;
                /// peticion tipo mapeo
                // lista = db.tb_Marca.Where(x => x.Nombre.Contains(filtro)).Skip(registrosDescartados).Take(numeroRegistroPagina).ToList();
                var listaDatos = (from m in db.tb_Proveedor
                                  where m.RazonSocial.Contains(filtro)
                                  select m).ToList();
                totalRegistros = listaDatos.Count();
                listaDatos = listaDatos.OrderBy(m => m.Id).Skip(registrosDescartados).Take(numeroRegistroPagina).ToList();
                lista = new MapeadorProveedorDatos().MapearTipo1Tipo2(listaDatos).ToList();
            }
            return lista;
        }
        /// <summary>
        /// metodo para guardar registro
        /// </summary>
        /// <param name="registro">registro objeto a guardar</param>
        /// <returns>true si guardo y false cuando ya existe un registro igual o hay una excepcion</returns>
        public bool GuardarRegistro(ProveedorDbModel registro)
        {
            try
            {

                using (EllaYelDBEntities db = new EllaYelDBEntities())
                {
                    // verificacion de un registro con el mismo nombre
                    if (db.tb_Proveedor.Where(x => x.RazonSocial.ToLower().Equals(registro.RazonSocial.ToLower())).Count() > 0)
                    {
                        return false;
                    }
                    MapeadorProveedorDatos mapeador = new MapeadorProveedorDatos();
                    var registroMapeado = mapeador.MapearTipo2Tipo1(registro);
                    db.tb_Proveedor.Add(registroMapeado);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public ProveedorDbModel BuscarRegistro(int id)
        {
            using (EllaYelDBEntities db = new EllaYelDBEntities())
            {
                tb_Proveedor registro = db.tb_Proveedor.Find(id);
                return new MapeadorProveedorDatos().MapearTipo1Tipo2(registro);
            }
        }
        public bool EditarRegistro(ProveedorDbModel registro)
        {
            try
            {

                using (EllaYelDBEntities db = new EllaYelDBEntities())
                {
                    if (db.tb_Proveedor.Where(x => x.Id == registro.Id).Count() == 0)
                    {
                        return false;
                    }
                    MapeadorProveedorDatos mapeador = new MapeadorProveedorDatos();
                    var registroMapeado = mapeador.MapearTipo2Tipo1(registro);
                    db.Entry(registroMapeado).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool BorrarRegistro(int id)
        {
            using (EllaYelDBEntities db = new EllaYelDBEntities())
            {
                tb_Proveedor registro = db.tb_Proveedor.Find(id);
                if (registro == null || registro.tb_Zapato.Count() > 0)
                {
                    return false;
                }
                db.tb_Proveedor.Remove(registro);
                db.SaveChanges();
                return true;
            }

        }
    }
}

