using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AccesoDeDatos.modelos;

namespace TiendaVirtual.Controllers.Cliente
{
    public class ClienteController : Controller
    {
        /*
        private EllaYelDBEntities db = new EllaYelDBEntities();

        // GET: Cliente
        public ActionResult Index()
        {
            var tb_Cliente = db.tb_Cliente.Include(t => t.tb_Vendedor);
            return View(tb_Cliente.ToList());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Cliente tb_Cliente = db.tb_Cliente.Find(id);
            if (tb_Cliente == null)
            {
                return HttpNotFound();
            }
            return View(tb_Cliente);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            ViewBag.Creador = new SelectList(db.tb_Vendedor, "Id", "Primer_Nombre");
            return View();
        }

        // POST: Cliente/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Primer_Nombre,Segundo_Nombre,Primer_Apellido,Segundo_Apellido,Numero_Doc,Celular,Email,Creador,Fecha_Creado,Editor,Fecha_Edicion")] tb_Cliente tb_Cliente)
        {
            if (ModelState.IsValid)
            {
                db.tb_Cliente.Add(tb_Cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Creador = new SelectList(db.tb_Vendedor, "Id", "Primer_Nombre", tb_Cliente.Creador);
            return View(tb_Cliente);
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Cliente tb_Cliente = db.tb_Cliente.Find(id);
            if (tb_Cliente == null)
            {
                return HttpNotFound();
            }
            ViewBag.Creador = new SelectList(db.tb_Vendedor, "Id", "Primer_Nombre", tb_Cliente.Creador);
            return View(tb_Cliente);
        }

        // POST: Cliente/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Primer_Nombre,Segundo_Nombre,Primer_Apellido,Segundo_Apellido,Numero_Doc,Celular,Email,Creador,Fecha_Creado,Editor,Fecha_Edicion")] tb_Cliente tb_Cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Creador = new SelectList(db.tb_Vendedor, "Id", "Primer_Nombre", tb_Cliente.Creador);
            return View(tb_Cliente);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Cliente tb_Cliente = db.tb_Cliente.Find(id);
            if (tb_Cliente == null)
            {
                return HttpNotFound();
            }
            return View(tb_Cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Cliente tb_Cliente = db.tb_Cliente.Find(id);
            db.tb_Cliente.Remove(tb_Cliente);
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
        */
    }
}
