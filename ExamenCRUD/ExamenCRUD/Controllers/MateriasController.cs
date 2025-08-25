using ExamenCRUD.Data;
using ExamenCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ExamenCRUD.Controllers
{
    public class MateriasController(AppDbContext context) : Controller
    {
        private readonly AppDbContext _context = context;

        // GET: Materias
        public async Task<IActionResult> Index(string? search)
        {
            var query = _context.Materias
                .Include(m => m.Carrera)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(m => m.Nombre.Contains(search));

            var list = await query
                .OrderBy(m => m.Carrera!.Nombre)
                .ThenBy(m => m.Nombre)
                .ToListAsync();

            ViewData["Search"] = search;
            return View(list);
        }

        // GET: Materias/Create
        public async Task<IActionResult> Create()
        {
            await SetCarrerasDropDown();
            return View(new Materia());
        }

        // POST: Materias/Create
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Materia materia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            await SetCarrerasDropDown(materia.CarreraId);
            return View(materia);
        }

        // GET: Materias/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var materia = await _context.Materias.FindAsync(id);
            if (materia is null) return NotFound();

            await SetCarrerasDropDown(materia.CarreraId);
            return View(materia);
        }

        // POST: Materias/Edit/5
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Materia materia)
        {
            if (id != materia.Id) return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materia);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _context.Materias.AnyAsync(m => m.Id == id))
                        return NotFound();
                    throw;
                }
            }
            await SetCarrerasDropDown(materia.CarreraId);
            return View(materia);
        }

        // POST: Materias/Delete/5  (sin página dedicada)
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var materia = await _context.Materias.FindAsync(id);
            if (materia is not null)
            {
                _context.Materias.Remove(materia);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private async Task SetCarrerasDropDown(int? selectedId = null)
        {
            var carreras = await _context.Carreras
                .OrderBy(c => c.Nombre)
                .Select(c => new { c.Id, c.Nombre })
                .ToListAsync();

            ViewBag.CarreraId = new SelectList(carreras, "Id", "Nombre", selectedId);
        }
    }
}
