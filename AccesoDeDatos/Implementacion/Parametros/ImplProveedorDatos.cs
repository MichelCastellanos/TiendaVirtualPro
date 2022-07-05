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
        public IEnumerable<ProveedorDbModel> ListarRegistros(string filtro)
        {
            var lista = new List<ProveedorDbModel>();
            using (EllaYelDBEntities db = new EllaYelDBEntities())
            {
                if (String.IsNullOrWhiteSpace(filtro))
                {
                    IEnumerable<tb_Proveedor> listaDatos = db.tb_Proveedor.ToList();
                    return new MapeadorProveedorDatos().MapearTipo1Tipo2(listaDatos);
                }
                else
                {
                    /// peticion tipo mapeo
                    IEnumerable<tb_Proveedor> listaDatos = db.tb_Proveedor.Where(x => x.RazonSocial.ToUpper().Contains(filtro.ToUpper())).ToList();
                    return new MapeadorProveedorDatos().MapearTipo1Tipo2(listaDatos);
                }
            }
        }
        /// <summary>
        /// metodo para guardar registro
        /// </summary>
        /// <param name="registro">registro objeto a guardar</param>
        /// <returns>true si guardo y false cuando ya existe un registro igual o hay una excepcion</returns>
        public bool GuardarRegistro(tb_Proveedor registro)
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
                    db.tb_Proveedor.Add(registro);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }/// <summary>
         /// metodo para buscar registro
         /// </summary>
         /// <param name="id">id del registro a buscar</param>
         /// <returns>objeto registro encontrado o null si lo encuentra</returns>
        public tb_Proveedor BuscarRegistro(int id)
        {
            using (EllaYelDBEntities db = new EllaYelDBEntities())
            {
                tb_Proveedor registro = db.tb_Proveedor.Find(id);
                return registro;
            }
        }
        /// <summary>
        /// metodo para editar registro
        /// </summary>
        /// <param name="registro">registro objeto a editar</param>
        /// <returns>true si es editado y false cuando no hay registro igual o hay una excepcion</returns>
        public bool EditarRegistro(tb_Proveedor registro)
        {
            try
            {
                using (EllaYelDBEntities db = new EllaYelDBEntities())
                {
                    // verificacion si existe el registro en la tabla de la base
                    if (db.tb_Proveedor.Where(x => x.Id == registro.Id).Count() == 0)
                    {
                        return false;
                    }
                    db.Entry(registro).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// metodo para borrar registro
        /// </summary>
        /// <param name="id">id del registro a borrar</param>
        /// <returns>true si borra registro y false cuando no existe el id del registro o hay una excepcion</returns>
        public bool BorrarRegistro(int id)
        {
            using (EllaYelDBEntities db = new EllaYelDBEntities())
            {
                // encontrar un registro con el id requerido
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

