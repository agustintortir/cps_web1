using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using WorldJourney.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldJourney.Controllers
{
    public class CityController : Controller
    {

        private IData _data { get; set; }
        private IHostingEnvironment _environment { get; set; }

        public CityController (IData data, IHostingEnvironment environment)
        {
            _data = data;
            _environment = environment;

            data.CityInitializeData();
        }

        // GET: CityController
        [Route("WorldJourney")]
        public ActionResult Index()
        { 
            ViewData["Page"] = "Search city";
            return View();
        }

        // GET: CityController/Details/5
        [Route("CityDetails/{id?}")]
        public IActionResult Details(int? id)
        {
            ViewData["Page"] = "Selected city";

            City city = _data.GetCityById(id);

            if (city == null)
            {
                return NotFound();
            }
            else
            {  
                ViewBag.Title = city.CityName;
                return View(city);
            }
        }



        // GET: CityController/Create
        public IActionResult GetImage(int? cityId)
        {
            ViewData["Message"] = "Display Image";

            City requestedCity = _data.GetCityById(cityId);

            if(requestedCity != null)
            {
                string webRootPath = _environment.WebRootPath;
                string folderPath = @"\images\";
                string fullPath = (webRootPath + folderPath + requestedCity.ImageName);

                FileStream fileOnDisk = new FileStream(fullPath, FileMode.Open);

                byte[] fileBytes;

                using (BinaryReader br = new BinaryReader(fileOnDisk))
                {
                    fileBytes = br.ReadBytes((int)fileOnDisk.Length);
                }

                return File(fileBytes, requestedCity.ImageMimeType);
            } else { return NotFound(); }
        }

        // POST: CityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CityController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CityController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
