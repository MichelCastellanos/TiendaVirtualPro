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
    public class CategoriaController : Controller
    {
        private EllaYelDBEntities db = new EllaYelDBEntities();

        // GET: Categoria
        public ActionResult Index()
        {
            return View(db.tb_Categoria.ToList());
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Categoria tb_Categoria = db.tb_Categoria.Find(id);
            if (tb_Categoria == null)
            {
                return HttpNotFound();
            }
            return View(tb_Categoria);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoria/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre")] tb_Categoria tb_Categoria)
        {
            if (ModelState.IsValid)
            {
                db.tb_Categoria.Add(tb_Categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Categoria);
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Categoria tb_Categoria = db.tb_Categoria.Find(id);
            if (tb_Categoria == null)
            {
                return HttpNotFound();
            }
            return View(tb_Categoria);
        }

        // POST: Categoria/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre")] tb_Categoria tb_Categoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Categoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Categoria);
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Categoria tb_Categoria = db.tb_Categoria.Find(id);
            if (tb_Categoria == null)
            {
                return HttpNotFound();
            }
            return View(tb_Categoria);
        }

        // POST: Categoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Categoria tb_Categoria = db.tb_Categoria.Find(id);
            db.tb_Categoria.Remove(tb_Categoria);
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
