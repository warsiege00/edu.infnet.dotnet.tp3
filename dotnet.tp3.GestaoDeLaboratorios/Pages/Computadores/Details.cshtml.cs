using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesComputador.Data;
using dotnet.tp3.GestaoDeLaboratorios.Models;

namespace dotnet.tp3.GestaoDeLaboratorios.Pages.Computadores
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesComputador.Data.InfnetDbContext _context;

        public DetailsModel(RazorPagesComputador.Data.InfnetDbContext context)
        {
            _context = context;
        }

      public Computador Computador { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Computador == null)
            {
                return NotFound();
            }

            var computador = await _context.Computador.FirstOrDefaultAsync(m => m.Id == id);
            if (computador == null)
            {
                return NotFound();
            }
            else 
            {
                Computador = computador;
            }
            return Page();
        }
    }
}
