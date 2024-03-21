using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesComputador.Data;
using dotnet.tp3.GestaoDeLaboratorios.Models;

namespace dotnet.tp3.GestaoDeLaboratorios.Pages.Computadores
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesComputador.Data.InfnetDbContext _context;

        public EditModel(RazorPagesComputador.Data.InfnetDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Computador Computador { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Computador == null)
            {
                return NotFound();
            }

            var computador =  await _context.Computador.FirstOrDefaultAsync(m => m.Id == id);
            if (computador == null)
            {
                return NotFound();
            }
            Computador = computador;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Computador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComputadorExists(Computador.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ComputadorExists(int id)
        {
          return (_context.Computador?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
