﻿using Safari.Entities;
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
            return View(ep.ListarTodos());
        }

        // GET: Especie/Details/5
        [Route("Detalles_Especie", Name = "EspecieControllerRouteDetails")]
        public ActionResult Details(int id)
        {
            EspeciesProcess ep = new EspeciesProcess();
            return View(ep.Ver(id));
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
                ep.Agregar(especie);
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
            return View(ep.Ver(id));
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
                ep.Editar(id, especie);
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
            return View(ep.Ver(id));
        }
        [Route("Eliminar_Especie", Name = "EspecieControllerRouteDeletePost")]
        // POST: Especie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                EspeciesProcess ep = new EspeciesProcess();
                ep.Eliminar(id);
                return RedirectToAction("Especie");
            }
            catch
            {
                return View();
            }
        }
    }
}