using AccesoDeDatos.modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos.Implementacion.Parametros
{
    public class ImplCategoriaDatos
    {
        /// <summary>
        /// metodo para listar registros
        /// </summary>
        /// <param name="filtro">filtro a aplicar</param>
        /// <returns></returns>
        public IEnumerable<tb_Categoria> ListarRegistros(string filtro)
        {
            var lista = new List<tb_Categoria>();
            using (EllaYelDBEntities db = new EllaYelDBEntities())
            {
                if (String.IsNullOrWhiteSpace(filtro))
                {
                    lista = db.tb_Categoria.ToList();
                }
                else
                {
                    /// peticion tipo mapeo
                    lista = db.tb_Categoria.Where(x => x.Nombre.ToUpper().Contains(filtro.ToUpper())).ToList();
                    /// peticion a base de datos tipo linq
                    /*
                    lista = (
                        from c in db.tb_Categoria
                        where c.Nombre.ToLower().Contains(filtro.ToLower())
                        select c 
                        ).ToList(); */
                }
            }
            return lista;
        }
        /// <summary>
        /// metodo para guardar registro
        /// </summary>
        /// <param name="registro">registro objeto a guardar</param>
        /// <returns>true si guardo y false cuando ya existe un registro igual o hay una excepcion</returns>
        public bool GuardarRegistro(tb_Categoria registro)
        {
            try
            {
                using (EllaYelDBEntities db = new EllaYelDBEntities())
                {
                    // verificacion de un registro con el mismo nombre
                    if (db.tb_Categoria.Where(x => x.Nombre.ToLower().Equals(registro.Nombre.ToLower())).Count() > 0)
                    {
                        return false;
                    }
                    db.tb_Categoria.Add(registro);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public tb_Categoria BuscarRegistro(int id)
        {
            using (EllaYelDBEntities db = new EllaYelDBEntities())
            {
                tb_Categoria registro = db.tb_Categoria.Find(id);
                return registro;
            }
        }
        public bool EditarRegistro(tb_Categoria registro)
        {
            try
            {
                using (EllaYelDBEntities db = new EllaYelDBEntities())
                {
                    if (db.tb_Categoria.Where(x => x.Id == registro.Id).Count() == 0)
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
        public bool BorrarRegistro(int id)
        {
            using (EllaYelDBEntities db = new EllaYelDBEntities())
            {
                tb_Categoria registro = db.tb_Categoria.Find(id);
                if (registro == null || registro.tb_Zapato.Count() > 0)
                {
                    return false;
                }
                db.tb_Categoria.Remove(registro);
                db.SaveChanges();
                return true;
            }

        }
    }
}

