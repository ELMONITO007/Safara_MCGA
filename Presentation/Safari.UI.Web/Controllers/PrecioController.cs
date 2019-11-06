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
    public class PrecioController : Controller
    {
        
           [Route("Precio", Name = "PrecioControllerRouteIndex")]
        // GET: Precio
        public ActionResult Index()
        {
            return View();
        }

        [Route("Detalle_Precio", Name = "PrecioControllerRouteDetails")]
        // GET: Precio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [Route("Crear_Precio", Name = "PrecioControllerRouteCreateGet")]
        // GET: Precio/Create
        public ActionResult Create()
        {
            return View();
        }

        [Route("Crear_Precio", Name = "PrecioControllerRouteCreatePost")]
        // POST: Precio/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [Route("Editar_Precio", Name = "PrecioControllerRouteEditGet")]
        // GET: Precio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        [Route("Editar_Precio", Name = "PrecioControllerRouteEditPost")]
        // POST: Precio/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [Route("Eliminar_Precio", Name = "PrecioControllerRouteDeleteGet")]
        // GET: Precio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        [Route("Eliminar_Precio", Name = "PrecioControllerRouteDeletePost")]
        [HttpPost]
        // POST: Precio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
