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

namespace TiendaVirtual.Controllers.Parametros
{
    public class MarcaController : Controller
    {
        private ImplMarcaDatos acceso = new ImplMarcaDatos();

        // GET: Marca
        public ActionResult Index(String filtro= "")
        {
                return View(acceso.ListarRegistros(String.Empty));
        }

        // GET: Marca/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Marca tb_Marca = acceso.BuscarRegistro(id.Value);
            if (tb_Marca == null)
            {
                return HttpNotFound();
            }
            return View(tb_Marca);
        }

        // GET: Marca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Marca/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre")] tb_Marca tb_Marca)
        {
            if (ModelState.IsValid)
            {
                acceso.GuardarRegistro(tb_Marca);
                return RedirectToAction("Index");
            }

            return View(tb_Marca);
        }

        // GET: Marca/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Marca tb_Marca = acceso.BuscarRegistro(id.Value);
            if (tb_Marca == null)
            {
                return HttpNotFound();
            }
            return View(tb_Marca);
        }

        // POST: Marca/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre")] tb_Marca tb_Marca)
        {
            if (ModelState.IsValid)
            {
                acceso.EditarRegistro(tb_Marca);
                return RedirectToAction("Index");
            }
            return View(tb_Marca);
        }

        // GET: Marca/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Marca tb_Marca = acceso.BuscarRegistro(id.Value);
            if (tb_Marca == null)
            {
                return HttpNotFound();
            }
            return View(tb_Marca);
        }

        // POST: Marca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            acceso.BorrarRegistro(id);
            return RedirectToAction("Index");
        }

        
    }
}
