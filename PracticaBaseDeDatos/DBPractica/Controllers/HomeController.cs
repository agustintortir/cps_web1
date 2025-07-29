using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBPractica.Models;

namespace DBPractica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AdmArticulo objAdmArt = new AdmArticulo();
            return View(objAdmArt.TraerTodos());
        }

        public ActionResult Alta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Alta (FormCollection coleccion)
        {
            AdmArticulo objAdmArt = new AdmArticulo();
            Articulo articulo = new Articulo
            {
                Codigo = int.Parse(coleccion["codigo"].ToString()),
                Descripcion = coleccion["descripcion"],
                Precio = float.Parse(coleccion["precio"].ToString())
            };
            objAdmArt.Alta(articulo);
            return RedirectToAction("Index");
        }

        public ActionResult Baja (int cod)
        {
            AdmArticulo objAdmArt = new AdmArticulo();
            objAdmArt.Borrar(cod);
            return RedirectToAction("Index");
        }

        public ActionResult Modificacion(int cod)
        {
            AdmArticulo objAdmArt = new AdmArticulo();
            Articulo articulo = objAdmArt.TraerArticulo(cod);
            return View(articulo);
        }

        [HttpPost]
        public ActionResult Modificacion(FormCollection coleccion)
        {
            AdmArticulo objAdmArt = new AdmArticulo();
            Articulo articulo = new Articulo
            {
                Codigo = int.Parse(coleccion["codigo"].ToString()),
                Descripcion = coleccion["descripcion"].ToString(),
                Precio = float.Parse(coleccion["precio"].ToString())
            };
            objAdmArt.Modificar(articulo);
            return RedirectToAction("Index");
        }
    }
}