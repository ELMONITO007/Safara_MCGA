using Safari.Entities;
using Safari.UI.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Safari.UI.Web.Controllers
{
    public class EspecieController : Controller

    {
        [Route("especie", Name = "EspecieControllerRouteIndex")]
        public ActionResult Index()
        {
            EspeciesProcess ep = new EspeciesProcess();
            return View(ep.ListarTodos());
        }

        // GET: Especie/Details/5
        [Route("Detalles", Name = "EspecieControllerRouteDetails")]
        public ActionResult Details(int id)
        {
            EspeciesProcess ep = new EspeciesProcess();
            return View(ep.Ver(id));
        }

        // GET: Especie/Create

        public ActionResult Create()
        {
            return View();
        }
        [Route("crear", Name = "EspecieControllerRouteCreate")]
        // POST: Especie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                EspeciesProcess ep = new EspeciesProcess();
                Especie especie = new Especie();
                especie.Nombre = collection.Get("Nombre");
                ep.Agregar(especie);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Especie/Edit/5
        [Route("editar", Name = "EspecieControllerRouteEdit")]
        public ActionResult Edit(int id)
        {
            EspeciesProcess ep = new EspeciesProcess();
            return View(ep.Ver(id));
        }

        // POST: Especie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                EspeciesProcess ep = new EspeciesProcess();
                Especie especie = new Especie();
                especie.Id = Convert.ToInt32(collection.Get("Id"));
                especie.Nombre = collection.Get("Nombre");
                ep.Editar(id, especie);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Especie/Delete/5
        [Route("eliminar", Name = "EspecieControllerRouteDelete")]
        public ActionResult Delete(int id)
        {
            EspeciesProcess ep = new EspeciesProcess();
            return View(ep.Ver(id));
        }

        // POST: Especie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                EspeciesProcess ep = new EspeciesProcess();
                ep.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
