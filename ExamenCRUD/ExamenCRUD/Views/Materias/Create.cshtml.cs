using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ExamenCRUD.Data;
using ExamenCRUD.Models;

namespace ExamenCRUD.Controllers
{
    public class CreateModel : PageModel
    {
        private readonly ExamenCRUD.Data.AppDbContext _context;

        public CreateModel(ExamenCRUD.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CarreraId"] = new SelectList(_context.Carreras, "Id", "Nombre");
            return Page();
        }

        [BindProperty]
        public Materia Materia { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Materias.Add(Materia);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
