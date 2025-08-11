using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShirtStoreWebsite.Models;
using ShirtStoreWebsite.Services;

namespace ShirtStoreWebsite.Controllers
{
    public class ShirtController : Controller
    {

        public IActionResult Index()
        {
            IEnumerable<Shirt> shirts = _repository.GetShirts();
            return View(shirts);
        }

        public IActionResult AddShirt(Shirt shirt)
        {
            _repository.AddShirt(shirt);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repository.RemoveShirt(id);
            return RedirectToAction("Index");
        }
        public IShirtRepository _repository;

        public ShirtController (IShirtRepository repository)
        {
            _repository = repository;
        }
    }
}