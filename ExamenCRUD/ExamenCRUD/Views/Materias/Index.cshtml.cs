using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExamenCRUD.Data;
using ExamenCRUD.Models;

namespace ExamenCRUD.Controllers
{
    public class IndexModel : PageModel
    {
        private readonly ExamenCRUD.Data.AppDbContext _context;

        public IndexModel(ExamenCRUD.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Materia> Materia { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Materia = await _context.Materias
                .Include(m => m.Carrera).ToListAsync();
        }
    }
}
