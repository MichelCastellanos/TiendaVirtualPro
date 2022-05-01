using AccesoDeDatos.modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.Implementacion.Parametros
{
    public class ImplMarcaDatos
    {
        /// <summary>
        /// metodo para listar registros
        /// </summary>
        /// <param name="filtro">filtro a aplicar</param>
        /// <returns></returns>
        public IEnumerable <tb_Marca> ListarRegistros(String filtro)
        {
            var lista = new List<tb_Marca>();
            using (EllaYelDBEntities db = new EllaYelDBEntities())
            {
                if (String.IsNullOrWhiteSpace(filtro))
                {
                    lista = db.tb_Marca.ToList();
                }
                else
                {
                    /// peticion tipo mapeo
                    lista = db.tb_Marca.Where(x => x.Nombre.ToUpper().Contains(filtro.ToUpper())).ToList();
                }
            }
            return lista;
        }
        /// <summary>
        /// metodo para guardar registro
        /// </summary>
        /// <param name="registro">registro objeto a guardar</param>
        /// <returns>true si guardo y false cuando ya existe un registro igual o hay una excepcion</returns>
        public bool GuardarRegistro(tb_Marca registro)
        {
            try
            {
                using (EllaYelDBEntities db = new EllaYelDBEntities())
                {
                    // verificacion de un registro con el mismo nombre
                    if(db.tb_Marca.Where(x => x.Nombre.ToLower().Equals(registro.Nombre.ToLower())).Count() > 0)
                    {
                        return false;
                    }
                    db.tb_Marca.Add(registro);
                    db.SaveChanges();
                    return true;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
        }/// <summary>
        /// metodo para buscar registro
        /// </summary>
        /// <param name="id">id del registro a buscar</param>
        /// <returns>objeto registro encontrado o null si lo encuentra</returns>
        public tb_Marca BuscarRegistro(int id)
        {
            using (EllaYelDBEntities db = new EllaYelDBEntities())
            {
                tb_Marca registro = db.tb_Marca.Find(id);
                return registro;
            }
        }
        /// <summary>
        /// metodo para editar registro
        /// </summary>
        /// <param name="registro">registro objeto a editar</param>
        /// <returns>true si es editado y false cuando no hay registro igual o hay una excepcion</returns>
        public bool EditarRegistro(tb_Marca registro)
        {
            try
            {
                using (EllaYelDBEntities db = new EllaYelDBEntities())
                {
                    // verificacion si existe el registro en la tabla de la base
                    if (db.tb_Marca.Where(x => x.Id == registro.Id).Count() == 0)
                    {
                        return false;
                    }
                    db.Entry(registro).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }

            }catch(Exception e)
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
                tb_Marca registro = db.tb_Marca.Find(id);
                if(registro == null)
                {
                    return false;
                }
                db.tb_Marca.Remove(registro);
                db.SaveChanges();
                return true;
            }
            
        }
    }
}
