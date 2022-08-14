using Logica.DTO.Parametros;
using Logica.Implementacion.Parametros;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TiendaVirtual.Helpers;
using TiendaVirtual.Mapeadores.Parametros;
using TiendaVirtual.Models.ModelosGUI.Parametros;

namespace TiendaVirtual.Controllers.Parametros
{
    public class CategoriaController : Controller
    {
        private ImplCategoriaLogica logica = new ImplCategoriaLogica();

        // GET: Marca
        public ActionResult Index(int? page, String filtro = "")
        {
            int numeroPag = page ?? 1;
            int totalRegistros;
            int numeroRegistrosPagina = DatosGenerales.RegistrosPorPagina;
            IEnumerable<CategoriaDTO> ListaDatos = logica.ListarRegistros(filtro, numeroPag, numeroRegistrosPagina, out totalRegistros).ToList();
            MapeadorCategoriaGUI mapper = new MapeadorCategoriaGUI();
            IEnumerable<ModeloCategoriaGUI> ListaGUI = mapper.MapearTipo1Tipo2(ListaDatos);
            //var registrosPagina = ListaGUI.ToPagedList(numeroPag, 25);
            var listaPagina = new StaticPagedList<ModeloCategoriaGUI>(ListaGUI, numeroPag, numeroRegistrosPagina, totalRegistros);
            return View(listaPagina);
        }

        // GET: Marca/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaDTO CategoriaDTO = logica.BuscarRegistro(id.Value);
            if (CategoriaDTO == null)
            {
                return HttpNotFound();
            }
            MapeadorCategoriaGUI mapper = new MapeadorCategoriaGUI();
            ModeloCategoriaGUI modelo = mapper.MapearTipo1Tipo2(CategoriaDTO);
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
        public ActionResult Create([Bind(Include = "Id,Nombre")] ModeloCategoriaGUI modelo)
        {
            if (ModelState.IsValid)
            {
                MapeadorCategoriaGUI mapper = new MapeadorCategoriaGUI();
                CategoriaDTO marca = mapper.MapearTipo2Tipo1(modelo);
                logica.GuardarRegistro(marca);
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
            CategoriaDTO CategoriaDTO = logica.BuscarRegistro(id.Value);
            if (CategoriaDTO == null)
            {
                return HttpNotFound();
            }
            MapeadorCategoriaGUI mapper = new MapeadorCategoriaGUI();
            ModeloCategoriaGUI modelo = mapper.MapearTipo1Tipo2(CategoriaDTO);
            return View(modelo);
        }

        // POST: Marca/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre")] ModeloCategoriaGUI modelo)
        {
            if (ModelState.IsValid)
            {
                MapeadorCategoriaGUI mapper = new MapeadorCategoriaGUI();
                CategoriaDTO marca = mapper.MapearTipo2Tipo1(modelo);
                logica.EditarRegistro(marca);
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
            CategoriaDTO CategoriaDTO = logica.BuscarRegistro(id.Value);
            if (CategoriaDTO == null)
            {
                return HttpNotFound();
            }
            MapeadorCategoriaGUI mapper = new MapeadorCategoriaGUI();
            ModeloCategoriaGUI modelo = mapper.MapearTipo1Tipo2(CategoriaDTO);
            return View(modelo);
        }

        // POST: Marca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            bool respuesta = logica.BorrarRegistro(id);
            // si hay un registro encontrado
            if (respuesta)
            {
                return RedirectToAction("Index");
            }
            // FALSE : si no hay registro encontrado
            else
            {
                // rebuscar el id para volverlo a la vista
                CategoriaDTO CategoriaDTO = logica.BuscarRegistro(id);
                if (CategoriaDTO == null)
                {
                    return HttpNotFound();
                }
                // mapear y mostrar el mensaje con el objeto a borrar
                MapeadorCategoriaGUI mapper = new MapeadorCategoriaGUI();
                ViewBag.Mensaje = Mensajes.MensajeErrorBorrar;
                ModeloCategoriaGUI modelo = mapper.MapearTipo1Tipo2(CategoriaDTO);
                // retornar la vista con su respecivo modelo anterior
                return View(modelo);
            }
        }


    }
}
