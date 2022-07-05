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
    public class ImplCategoriaDatos
    {
        /// <summary>
        /// metodo para listar registros
        /// </summary>
        /// <param name="filtro">filtro a aplicar</param>
        /// <returns></returns>
        public IEnumerable<CategoriaDbModel> ListarRegistros(string filtro)
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
            return new MapeadorCategoriaDatos().MapearTipo1Tipo2(lista);
        }
        /// <summary>
        /// metodo para guardar registro
        /// </summary>
        /// <param name="registro">registro objeto a guardar</param>
        /// <returns>true si guardo y false cuando ya existe un registro igual o hay una excepcion</returns>
        public bool GuardarRegistro(CategoriaDbModel registro)
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
                    MapeadorCategoriaDatos mapeador = new MapeadorCategoriaDatos();
                    var registroMapeado = mapeador.MapearTipo2Tipo1(registro);
                    db.tb_Categoria.Add(registroMapeado);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public CategoriaDbModel BuscarRegistro(int id)
        {
            using (EllaYelDBEntities db = new EllaYelDBEntities())
            {
                tb_Categoria registro = db.tb_Categoria.Find(id);
                return new MapeadorCategoriaDatos().MapearTipo1Tipo2(registro);
            }
        }
        public bool EditarRegistro(CategoriaDbModel registro)
        {
            try
            {
                
                using (EllaYelDBEntities db = new EllaYelDBEntities())
                {
                    if (db.tb_Categoria.Where(x => x.Id == registro.Id).Count() == 0)
                    {
                        return false;
                    }
                    MapeadorCategoriaDatos mapeador = new MapeadorCategoriaDatos();
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

