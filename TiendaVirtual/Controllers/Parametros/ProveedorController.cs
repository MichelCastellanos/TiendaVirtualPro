using AccesoDeDatos.Implementacion.Parametros;
using AccesoDeDatos.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TiendaVirtual.Mapeadores.Parametros;
using TiendaVirtual.Models.ModelosGUI.Parametros;
using TiendaVirtual.Helpers;

namespace TiendaVirtual.Controllers.Parametros
{
    public class ProveedorController : Controller
    {
        private ImplProveedorDatos acceso = new ImplProveedorDatos();

        // GET: Marca
        public ActionResult Index(String filtro = "")
        {
            IEnumerable<tb_Proveedor> ListaDatos = acceso.ListarRegistros(filtro).ToList();
            MapeadorProveedorGUI mapper = new MapeadorProveedorGUI();
            IEnumerable<ModeloProveedorGUI> ListaGUI = mapper.MapearTipo1Tipo2(ListaDatos);
            return View(ListaGUI);

        }

        // GET: Marca/Details/5
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
            MapeadorProveedorGUI mapper = new MapeadorProveedorGUI();
            ModeloProveedorGUI modelo = mapper.MapearTipo1Tipo2(tb_Proveedor);
            return View(modelo);
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
        public ActionResult Create([Bind(Include = "Id,Nombre")] ModeloProveedorGUI modelo)
        {
            if (ModelState.IsValid)
            {
                MapeadorProveedorGUI mapper = new MapeadorProveedorGUI();
                tb_Proveedor marca = mapper.MapearTipo2Tipo1(modelo);
                acceso.GuardarRegistro(marca);
                return RedirectToAction("Index");
            }

            return View(modelo);
        }

        // GET: Marca/Edit/5
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
            MapeadorProveedorGUI mapper = new MapeadorProveedorGUI();
            ModeloProveedorGUI modelo = mapper.MapearTipo1Tipo2(tb_Proveedor);
            return View(modelo);
        }

        // POST: Marca/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre")] ModeloProveedorGUI modelo)
        {
            if (ModelState.IsValid)
            {
                MapeadorProveedorGUI mapper = new MapeadorProveedorGUI();
                tb_Proveedor marca = mapper.MapearTipo2Tipo1(modelo);
                acceso.EditarRegistro(marca);
                return RedirectToAction("Index");
            }

            return View(modelo);
        }

        // GET: Marca/Delete/5
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
            MapeadorProveedorGUI mapper = new MapeadorProveedorGUI();
            ModeloProveedorGUI modelo = mapper.MapearTipo1Tipo2(tb_Proveedor);
            return View(modelo);
        }

        // POST: Marca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            bool respuesta = acceso.BorrarRegistro(id);
            // si hay un registro encontrado
            if (respuesta)
            {
                return RedirectToAction("Index");
            }
            // FALSE : si no hay registro encontrado
            else
            {
                // rebuscar el id para volverlo a la vista
                tb_Proveedor tb_Proveedor = acceso.BuscarRegistro(id);
                if (tb_Proveedor == null)
                {
                    return HttpNotFound();
                }
                // mapear y mostrar el mensaje con el objeto a borrar
                MapeadorProveedorGUI mapper = new MapeadorProveedorGUI();
                ViewBag.Mensaje = Mensajes.MensajeErrorBorrar;
                ModeloProveedorGUI modelo = mapper.MapearTipo1Tipo2(tb_Proveedor);
                // retornar la vista con su respecivo modelo anterior
                return View(modelo);
            }
        }


    }
}
