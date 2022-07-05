using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AccesoDeDatos.modelos;

namespace TiendaVirtual.Controllers.Zapatos
{
    public class ZapatoController : Controller
    {
        /*
        private EllaYelDBEntities db = new EllaYelDBEntities();

        // GET: Zapato
        public ActionResult Index()
        {
            var tb_Zapato = db.tb_Zapato.Include(t => t.tb_Categoria).Include(t => t.tb_Marca).Include(t => t.tb_Proveedor);
            return View(tb_Zapato.ToList());
        }

        // GET: Zapato/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Zapato tb_Zapato = db.tb_Zapato.Find(id);
            if (tb_Zapato == null)
            {
                return HttpNotFound();
            }
            return View(tb_Zapato);
        }

        // GET: Zapato/Create
        public ActionResult Create()
        {
            ViewBag.Id_Categoria = new SelectList(db.tb_Categoria, "Id", "Nombre");
            ViewBag.Id_Marca = new SelectList(db.tb_Marca, "Id", "Nombre");
            ViewBag.Id_Proveedor = new SelectList(db.tb_Proveedor, "Id", "RazonSocial");
            return View();
        }

        // POST: Zapato/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Color,Modelo,Precio,Descuento,Talla,Estado,Genero,Id_Proveedor,Id_Marca,Id_Categoria")] tb_Zapato tb_Zapato)
        {
            if (ModelState.IsValid)
            {
                db.tb_Zapato.Add(tb_Zapato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Categoria = new SelectList(db.tb_Categoria, "Id", "Nombre", tb_Zapato.Id_Categoria);
            ViewBag.Id_Marca = new SelectList(db.tb_Marca, "Id", "Nombre", tb_Zapato.Id_Marca);
            ViewBag.Id_Proveedor = new SelectList(db.tb_Proveedor, "Id", "RazonSocial", tb_Zapato.Id_Proveedor);
            return View(tb_Zapato);
        }

        // GET: Zapato/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Zapato tb_Zapato = db.tb_Zapato.Find(id);
            if (tb_Zapato == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Categoria = new SelectList(db.tb_Categoria, "Id", "Nombre", tb_Zapato.Id_Categoria);
            ViewBag.Id_Marca = new SelectList(db.tb_Marca, "Id", "Nombre", tb_Zapato.Id_Marca);
            ViewBag.Id_Proveedor = new SelectList(db.tb_Proveedor, "Id", "RazonSocial", tb_Zapato.Id_Proveedor);
            return View(tb_Zapato);
        }

        // POST: Zapato/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Color,Modelo,Precio,Descuento,Talla,Estado,Genero,Id_Proveedor,Id_Marca,Id_Categoria")] tb_Zapato tb_Zapato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Zapato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Categoria = new SelectList(db.tb_Categoria, "Id", "Nombre", tb_Zapato.Id_Categoria);
            ViewBag.Id_Marca = new SelectList(db.tb_Marca, "Id", "Nombre", tb_Zapato.Id_Marca);
            ViewBag.Id_Proveedor = new SelectList(db.tb_Proveedor, "Id", "RazonSocial", tb_Zapato.Id_Proveedor);
            return View(tb_Zapato);
        }

        // GET: Zapato/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Zapato tb_Zapato = db.tb_Zapato.Find(id);
            if (tb_Zapato == null)
            {
                return HttpNotFound();
            }
            return View(tb_Zapato);
        }

        // POST: Zapato/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Zapato tb_Zapato = db.tb_Zapato.Find(id);
            db.tb_Zapato.Remove(tb_Zapato);
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
