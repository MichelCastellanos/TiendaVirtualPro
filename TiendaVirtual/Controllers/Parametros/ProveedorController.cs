using System.Web.Mvc;

namespace TiendaVirtual.Controllers.Parametros
{
    public class ProveedorController : Controller
    {
        /*
        private ImplProveedorLogica logica = new ImplProveedorLogica();

        // GET: Marca
        public ActionResult Index(String filtro = "")
        {
            IEnumerable<ProveedorDTO> ListaDatos = logica.ListarRegistros(filtro).ToList();
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
            ProveedorDTO ProveedorDTO = logica.BuscarRegistro(id.Value);
            if (ProveedorDTO == null)
            {
                return HttpNotFound();
            }
            MapeadorProveedorGUI mapper = new MapeadorProveedorGUI();
            ModeloProveedorGUI modelo = mapper.MapearTipo1Tipo2(ProveedorDTO);
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
                ProveedorDTO marca = mapper.MapearTipo2Tipo1(modelo);
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
            ProveedorDTO ProveedorDTO = logica.BuscarRegistro(id.Value);
            if (ProveedorDTO == null)
            {
                return HttpNotFound();
            }
            MapeadorProveedorGUI mapper = new MapeadorProveedorGUI();
            ModeloProveedorGUI modelo = mapper.MapearTipo1Tipo2(ProveedorDTO);
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
                ProveedorDTO marca = mapper.MapearTipo2Tipo1(modelo);
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
            ProveedorDTO ProveedorDTO = logica.BuscarRegistro(id.Value);
            if (ProveedorDTO == null)
            {
                return HttpNotFound();
            }
            MapeadorProveedorGUI mapper = new MapeadorProveedorGUI();
            ModeloProveedorGUI modelo = mapper.MapearTipo1Tipo2(ProveedorDTO);
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
                ProveedorDTO ProveedorDTO = logica.BuscarRegistro(id);
                if (ProveedorDTO == null)
                {
                    return HttpNotFound();
                }
                // mapear y mostrar el mensaje con el objeto a borrar
                MapeadorProveedorGUI mapper = new MapeadorProveedorGUI();
                ViewBag.Mensaje = Mensajes.MensajeErrorBorrar;
                ModeloProveedorGUI modelo = mapper.MapearTipo1Tipo2(ProveedorDTO);
                // retornar la vista con su respecivo modelo anterior
                return View(modelo);
            }
        }
        */
    }
}
