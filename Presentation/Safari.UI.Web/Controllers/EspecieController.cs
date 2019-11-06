using Safari.Entities;
using Safari.UI.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Safari.UI.Web.Controllers
{ [Authorize]
    public class EspecieController : Controller

    {
        [Route("Especie", Name = "EspecieControllerRouteIndex")]
        public ActionResult Index()
        {
            EspeciesProcess ep = new EspeciesProcess();
            var lista = ep.ToList();
            return View(lista);
        }



        // GET: Especie/Details/5
        [Route("Detalles_Especie", Name = "EspecieControllerRouteDetails")]
        public ActionResult Details(int id)
        {
            EspeciesProcess ep = new EspeciesProcess();
            return View();
        }

        // GET: Especie/Create
        [Route("Crear_Especie", Name = "EspecieControllerRouteCreateGet")]
        public ActionResult Create()
        {
            return View();
        }
        [Route("Crear_Especie", Name = "EspecieControllerRouteCreatePost")]
        // POST: Especie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                EspeciesProcess ep = new EspeciesProcess();
                Especie especie = new Especie();
                especie.Nombre = collection.Get("Nombre");
                
                return RedirectToAction("Especie");
            }
            catch
            {
                return View();
            }
        }

        // GET: Especie/Edit/5
        [Route("Editar_Especie", Name = "EspecieControllerRouteEditGet")]
        public ActionResult Edit(int id)
        {
            EspeciesProcess ep = new EspeciesProcess();
            return View();
        }
        [Route("Editar_Especie", Name = "EspecieControllerRoutePost")]
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
             
                return RedirectToAction("Especie");
            }
            catch
            {
                return View();
            }
        }

        // GET: Especie/Delete/5
        [Route("Eliminar_Especie", Name = "EspecieControllerRouteDeleteGet")]
        public ActionResult Delete(int id)
        {
            EspeciesProcess ep = new EspeciesProcess();
            return View();
        }
        [Route("Eliminar_Especie", Name = "EspecieControllerRouteDeletePost")]
        // POST: Especie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                EspeciesProcess ep = new EspeciesProcess();
               
                return RedirectToAction("Especie");
            }
            catch
            {
                return View();
            }
        }
    }
}
