using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TiendaVirtual.Models;

namespace TiendaVirtual.Controllers.Parametros
{
    public class ProveedorController : Controller
    {
        private EllaYelDBEntities db = new EllaYelDBEntities();

        // GET: Proveedor
        public ActionResult Index()
        {
            return View(db.tb_Proveedor.ToList());
        }

        // GET: Proveedor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Proveedor tb_Proveedor = db.tb_Proveedor.Find(id);
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
                db.tb_Proveedor.Add(tb_Proveedor);
                db.SaveChanges();
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
            tb_Proveedor tb_Proveedor = db.tb_Proveedor.Find(id);
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
                db.Entry(tb_Proveedor).State = EntityState.Modified;
                db.SaveChanges();
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
            tb_Proveedor tb_Proveedor = db.tb_Proveedor.Find(id);
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
            tb_Proveedor tb_Proveedor = db.tb_Proveedor.Find(id);
            db.tb_Proveedor.Remove(tb_Proveedor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
