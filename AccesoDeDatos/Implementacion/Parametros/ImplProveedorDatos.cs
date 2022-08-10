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
        public IEnumerable<ProveedorDbModel> ListarRegistros(string filtro)
        {
            var lista = new List<tb_Proveedor>();
            using (EllaYelDBEntities db = new EllaYelDBEntities())
            {
                if (String.IsNullOrWhiteSpace(filtro))
                {
                    lista = db.tb_Proveedor.ToList();
                }
                else
                {
                    /// peticion tipo mapeo
                    lista = db.tb_Proveedor.Where(x => x.RazonSocial.ToUpper().Contains(filtro.ToUpper())).ToList();
                    /// peticion a base de datos tipo linq
                    /*
                    lista = (
                        from c in db.tb_Proveedor
                        where c.Nombre.ToLower().Contains(filtro.ToLower())
                        select c 
                        ).ToList(); */
                }
            }
            return new MapeadorProveedorDatos().MapearTipo1Tipo2(lista);
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

