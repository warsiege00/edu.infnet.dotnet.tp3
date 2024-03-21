using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesComputador.Data;
using dotnet.tp3.GestaoDeLaboratorios.Models;

namespace dotnet.tp3.GestaoDeLaboratorios.Pages.Computadores
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesComputador.Data.InfnetDbContext _context;

        public CreateModel(RazorPagesComputador.Data.InfnetDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Computador Computador { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Computador == null || Computador == null)
            {
                return Page();
            }

            _context.Computador.Add(Computador);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
