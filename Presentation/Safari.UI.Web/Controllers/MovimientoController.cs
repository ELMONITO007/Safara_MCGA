using Safari.Entities;
using Safari.UI.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Safari.UI.Web.Controllers
{
    [Authorize]
    public class MovimientoController : Controller
    {
        [Route("Movimiento", Name = "MovimientoControllerRouteIndex")]
        // GET: Movimiento
        public ActionResult Index()
        {
            MovimientoProcess ep = new MovimientoProcess();
            var lista = ep.ToList();
            return View(lista);
        }
        [Route("Detalle_Movimiento", Name = "MovimientoControllerRouteDetails")]
        // GET: Movimiento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [Route("Crear_Movimiento", Name = "MovimientoControllerRouteCreateGet")]
        // GET: Movimiento/Create
        public ActionResult Create()
        {
            return View();
        }
        [Route("Crear_Movimiento", Name = "MovimientoControllerRouteCreatePost")]
        // POST: Movimiento/Create
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
        [Route("Editar_Movimiento", Name = "MovimientoControllerRouteEditGet")]
        // GET: Movimiento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        [Route("Editar_Movimiento", Name = "MovimientoControllerRouteEditPost")]
        // POST: Movimiento/Edit/5
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
        [Route("Eliminar_Movimiento", Name = "MovimientoControllerRouteDeleteGet")]
        // GET: Movimiento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        [Route("Eliminar_Movimiento", Name = "MovimientoControllerRouteDeletePost")]
        // POST: Movimiento/Delete/5
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
