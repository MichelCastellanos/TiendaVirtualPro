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
    public class CategoriaController : Controller
    {
        private ImplCategoriaDatos acceso = new ImplCategoriaDatos();

        // GET: Categoria
        public ActionResult Index(string filtro="")
        {
                return View(acceso.ListarRegistros(filtro));
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Categoria tb_Categoria = acceso.BuscarRegistro(id.Value);
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
                acceso.GuardarRegistro(tb_Categoria);
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
            tb_Categoria tb_Categoria = acceso.BuscarRegistro(id.Value);
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
                acceso.EditarRegistro(tb_Categoria);
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
            tb_Categoria tb_Categoria = acceso.BuscarRegistro(id.Value);
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
            acceso.BorrarRegistro(id);
            return RedirectToAction("Index");
        }

    }
}
