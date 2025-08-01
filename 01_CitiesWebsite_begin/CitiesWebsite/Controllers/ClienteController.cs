using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CitiesWebsite.Models;

namespace CitiesWebsite.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(Cliente cliente) 
        {

            /* agregar código para almacenar en la base de datos*/
            return RedirectToAction("Index");

        }

    }
}
