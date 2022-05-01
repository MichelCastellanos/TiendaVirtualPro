using AccesoDeDatos.Implementacion.Parametros;
using AccesoDeDatos.modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AccesoDeDatos.modelos;

namespace TiendaVirtual.Controllers.Parametros
{
    public class ProveedorController : Controller
    {
        private ImplProveedorDatos acceso = new ImplProveedorDatos();

        // GET: Proveedor
        public ActionResult Index(string filtro = "")
        {
                return View(acceso.ListarRegistros(filtro));
        }

        // GET: Proveedor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Proveedor tb_Proveedor = acceso.BuscarRegistro(id.Value);
            if (tb_Proveedor == null)
            {
                return HttpNotFound();
            }
            return View(tb_Proveedor);
        }

        // GET: Proveedor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proveedor/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RazonSocial,Jefe_Cargo,Direccion,Telefono,Email")] tb_Proveedor tb_Proveedor)
        {
            if (ModelState.IsValid)
            {
                acceso.GuardarRegistro(tb_Proveedor);
                return RedirectToAction("Index");
            }

            return View(tb_Proveedor);
        }

        // GET: Proveedor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Proveedor tb_Proveedor = acceso.BuscarRegistro(id.Value);
            if (tb_Proveedor == null)
            {
                return HttpNotFound();
            }
            return View(tb_Proveedor);
        }

        // POST: Proveedor/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RazonSocial,Jefe_Cargo,Direccion,Telefono,Email")] tb_Proveedor tb_Proveedor)
        {
            if (ModelState.IsValid)
            {
                acceso.EditarRegistro(tb_Proveedor);
                return RedirectToAction("Index");
            }
            return View(tb_Proveedor);
        }

        // GET: Proveedor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Proveedor tb_Proveedor = acceso.BuscarRegistro(id.Value);
            if (tb_Proveedor == null)
            {
                return HttpNotFound();
            }
            return View(tb_Proveedor);
        }

        // POST: Proveedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            acceso.BorrarRegistro(id);
            return RedirectToAction("Index");
        }
    }
}
