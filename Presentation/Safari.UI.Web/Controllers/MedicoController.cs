using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Safari.Entities;
using Safari.UI.Process;

namespace Safari.UI.Web.Controllers
{
    [Authorize]
    public class MedicoController : Controller
    {
        // GET: Medico
        [Route("Medico", Name = "MedicoControllerRouteIndex")]
        public ActionResult Index()
        {
            MedicoProcess ep = new MedicoProcess();
            return View(ep.ListarTodos());
        }

        // GET: Medico/Details/5
        [Route("Detalle_Medico", Name = "MedicoControllerRouteDetails")]
        public ActionResult Details(int id)
        {
            MedicoProcess ep = new MedicoProcess();
            return View(ep.Ver(id));
        }

        // GET: Medico/Create
        [Route("Crear_Medico", Name = "MedicoControllerRouteCreateGet")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Medico/Create
        [Route("Crear_Medico", Name = "MedicoControllerRouteCreatePost")]
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                MedicoProcess ep = new MedicoProcess();
                Medico medico = new Medico();
                medico.Nombre = collection.Get("Nombre");
                ep.Agregar(medico);
                return RedirectToAction("Medico");
            }
            catch
            {
                return View();
            }
        }

        // GET: Medico/Edit/5
        [Route("Editar_Medico", Name = "MedicoControllerRouteEditGet")]
        public ActionResult Edit(int id)
        {
            MedicoProcess ep = new MedicoProcess();
            return View(ep.Ver(id));
        }

        // POST: Medico/Edit/5
        [Route("Editar_Medico", Name = "MedicoControllerRouteEditPost")]
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                MedicoProcess ep = new MedicoProcess();
                Medico medico = new Medico();
                medico.Id = Convert.ToInt32(collection.Get("Id"));
                medico.Nombre = collection.Get("Nombre");
                ep.Editar(id, medico);
                return RedirectToAction("Medico");
            }
            catch
            {
                return View();
            }
        }

        // GET: Medico/Delete/5
        [Route("Eliminar_Medico", Name = "MedicoControllerRouteDeleteGet")]
        public ActionResult Delete(int id)
        {
            MedicoProcess ep = new MedicoProcess();
            return View(ep.Ver(id));
        }

        // POST: Medico/Delete/5
        [Route("Eliminar_Medico", Name = "MedicoControllerRouteDeletePost")]
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                MedicoProcess ep = new MedicoProcess();
                ep.Eliminar(id);
                return RedirectToAction("Medico");
            }
            catch
            {
                return View();
            }
        }
    }
}
