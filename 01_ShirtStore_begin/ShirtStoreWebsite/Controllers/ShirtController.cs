using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShirtStoreWebsite.Models;
using ShirtStoreWebsite.Services;
using Microsoft.Extensions.Logging;

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
            _logger.LogDebug($"A {shirt.Color.ToString()} shirt of size {shirt.Size.ToString()} with a price of {shirt.GetFormattedTaxedPrice()} was added succesfully");
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            try
            {
                _repository.RemoveShirt(id); 
                _logger.LogDebug($"A shirt with id {id} was removed succesfully");
                return RedirectToAction("Index");
            } catch (Exception ex)
            {
                _logger.LogError($"An error ocurred while trying to delete shirt with id {id}");
                throw ex;
            }
        }
        public IShirtRepository _repository;

        public ShirtController (IShirtRepository repository)
        {
            _repository = repository;
        }
        private ILogger _logger;
        public ShirtController (ILogger <ShirtController> logger)
        {
            _logger = logger;
        }
    }
}