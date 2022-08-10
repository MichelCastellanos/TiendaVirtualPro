using Logica.DTO.Zapato;
using Logica.Implementacion.Zapato;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TiendaVirtual.Helpers;
using TiendaVirtual.Mapeadores.Parametros;
using TiendaVirtual.Mapeadores.Zapato;
using TiendaVirtual.Models.ModelosGUI.Parametros;
using TiendaVirtual.Models.ModelosGUI.Zapato;

namespace TiendaVirtual.Controllers.Zapatos
{
    public class ZapatoController : Controller
    {

        private IEnumerable<SelectListItem> listadoCategorias;
        private IEnumerable<SelectListItem> listadoMarcas;
        private IEnumerable<SelectListItem> listadoProveedores;
        private ImplZapatoLogica logica = new ImplZapatoLogica();

        // GET: Marca
        public ActionResult Index(int? page, String filtro = "")
        {

            int numeroPag = page ?? 1;
            int totalRegistros;
            int numeroRegistrosPagina = DatosGenerales.RegistrosPorPagina;
            IEnumerable<ZapatoDTO> ListaDatos = logica.ListarRegistros(filtro, numeroPag, numeroRegistrosPagina, out totalRegistros).ToList();
            MapeadorZapatoGUI mapper = new MapeadorZapatoGUI();
            IEnumerable<ModeloZapatoGUI> ListaGUI = mapper.MapearTipo1Tipo2(ListaDatos);
            //var registrosPagina = ListaGUI.ToPagedList(numeroPag, 25);
            var listaPagina = new StaticPagedList<ModeloZapatoGUI>(ListaGUI, numeroPag, numeroRegistrosPagina, totalRegistros);
            return View(listaPagina);
        }

        // GET: Marca/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ZapatoDTO ZapatoDTO = logica.BuscarRegistro(id.Value);
            if (ZapatoDTO == null)
            {
                return HttpNotFound();
            }
            MapeadorZapatoGUI mapper = new MapeadorZapatoGUI();
            ModeloZapatoGUI modelo = mapper.MapearTipo1Tipo2(ZapatoDTO);
            return View(modelo);
        }

        // GET: Marca/Create
        public ActionResult Create()
        {
            Llenar();
            ModeloZapatoListadoGUI zapPro = new ModeloZapatoListadoGUI()
            {
                ListadoCategoria = listadoCategorias,
                ListadoProveedor = listadoProveedores,
                ListadoMarca = listadoMarcas
            };
            return View(zapPro);
        }

        // POST: Marca/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ModeloZapatoListadoGUI modelo)
        {
            ModeloZapatoGUI zapato = new ModeloZapatoGUI()
            {
                Id = modelo.Zapato.Id,
                Talla = modelo.Zapato.Talla,
                Color = modelo.Zapato.Color,
                Modelo = modelo.Zapato.Modelo,
                Precio = modelo.Zapato.Precio,
                Descuento = modelo.Zapato.Descuento,
                Estado = modelo.Zapato.Estado,
                Genero = modelo.Zapato.Genero,
                Id_Categoria = modelo.Zapato.Id_Categoria,
                Id_Proveedor = modelo.Zapato.Id_Proveedor,
                Id_Marca = modelo.Zapato.Id_Marca
            };
            if (ModelState.IsValid)
            {
                MapeadorZapatoGUI mapper = new MapeadorZapatoGUI();
                ZapatoDTO zapatoMapeado = mapper.MapearTipo2Tipo1(zapato);
                logica.GuardarRegistro(zapatoMapeado);
                return RedirectToAction("Index");
            }

            return View(zapato);
        }

        // GET: Marca/Edit/5
        public ActionResult Edit(int? id)
        {
            Llenar();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ZapatoDTO ZapatoDTO = logica.BuscarRegistro(id.Value);
            if (ZapatoDTO == null)
            {
                return HttpNotFound();
            }
            MapeadorZapatoGUI mapper = new MapeadorZapatoGUI();
            ModeloZapatoGUI modelo = mapper.MapearTipo1Tipo2(ZapatoDTO);
            ModeloZapatoListadoGUI modeloCompuesto = new ModeloZapatoListadoGUI();
            modeloCompuesto.Zapato = modelo;
            modeloCompuesto.ListadoCategoria = listadoCategorias;
            modeloCompuesto.ListadoMarca = listadoMarcas;
            modeloCompuesto.ListadoProveedor = listadoProveedores;
            return View(modeloCompuesto);
        }

        // POST: Marca/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ModeloZapatoListadoGUI modelo)
        {
            ModeloZapatoGUI zapato = new ModeloZapatoGUI()
            {
                Id = modelo.Zapato.Id,
                Talla = modelo.Zapato.Talla,
                Color = modelo.Zapato.Color,
                Modelo = modelo.Zapato.Modelo,
                Precio = modelo.Zapato.Precio,
                Descuento = modelo.Zapato.Descuento,
                Estado = modelo.Zapato.Estado,
                Genero = modelo.Zapato.Genero,
                Id_Categoria = modelo.Zapato.Id_Categoria,
                Id_Proveedor = modelo.Zapato.Id_Proveedor,
                Id_Marca = modelo.Zapato.Id_Marca
            };
            if (ModelState.IsValid)
            {
                MapeadorZapatoGUI mapper = new MapeadorZapatoGUI();
                ZapatoDTO zapatoMapeado = mapper.MapearTipo2Tipo1(zapato);
                logica.EditarRegistro(zapatoMapeado);
                return RedirectToAction("Index");
            }

            return View(zapato);
        }

        // GET: Marca/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ZapatoDTO ZapatoDTO = logica.BuscarRegistro(id.Value);
            if (ZapatoDTO == null)
            {
                return HttpNotFound();
            }
            MapeadorZapatoGUI mapper = new MapeadorZapatoGUI();
            ModeloZapatoGUI modelo = mapper.MapearTipo1Tipo2(ZapatoDTO);
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
                ZapatoDTO ZapatoDTO = logica.BuscarRegistro(id);
                if (ZapatoDTO == null)
                {
                    return HttpNotFound();
                }
                // mapear y mostrar el mensaje con el objeto a borrar
                MapeadorZapatoGUI mapper = new MapeadorZapatoGUI();
                ViewBag.Mensaje = Mensajes.MensajeErrorBorrar;
                ModeloZapatoGUI modelo = mapper.MapearTipo1Tipo2(ZapatoDTO);
                // retornar la vista con su respecivo modelo anterior
                return View(modelo);
            }
        }

        public List<ModeloMarcaGUI> ListadoMarca()
        {
            var lista = this.logica.ListadoMarca().ToList();
            MapeadorMarcaGUI mapeador = new MapeadorMarcaGUI();
            var listOne = mapeador.MapearTipo1Tipo2(lista).ToList();
            return listOne;
        }



        public List<ModeloCategoriaGUI> ListadoCategoria()
        {
            var lista = this.logica.ListadoCategoria().ToList();
            MapeadorCategoriaGUI mapeador = new MapeadorCategoriaGUI();
            var listOne = mapeador.MapearTipo1Tipo2(lista).ToList();
            return listOne;
        }

        public List<ModeloProveedorGUI> ListadoProveedor()
        {

            var lista = this.logica.ListadoProveedor().ToList();
            MapeadorProveedorGUI mapeador = new MapeadorProveedorGUI();
            var listOne = mapeador.MapearTipo1Tipo2(lista).ToList();
            return listOne;
        }


        public void Llenar()
        {
            listadoCategorias = ListadoCategoria().ToList().Select(p => new SelectListItem
            { Value = p.Id.ToString(), Text = p.Nombre }); ;
            listadoMarcas = ListadoMarca().ToList().Select(p => new SelectListItem
            { Value = p.Id.ToString(), Text = p.Nombre }); ;
            listadoProveedores = ListadoProveedor().ToList().Select(p => new SelectListItem
            { Value = p.Id.ToString(), Text = p.RazonSocial }); ;
        }
    }
}
