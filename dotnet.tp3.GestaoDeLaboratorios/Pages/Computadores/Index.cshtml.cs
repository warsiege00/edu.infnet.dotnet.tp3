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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesComputador.Data.InfnetDbContext _context;

        public IndexModel(RazorPagesComputador.Data.InfnetDbContext context)
        {
            _context = context;
        }

        public IList<Computador> Computador { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Computador != null)
            {
                Computador = await _context.Computador.ToListAsync();
            }
        }
    }
}
