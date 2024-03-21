using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnet.tp3.GestaoDeLaboratorios.Models;

namespace RazorPagesComputador.Data
{
    public class InfnetDbContext : DbContext
    {
        public InfnetDbContext(DbContextOptions<InfnetDbContext> options)
            : base(options)
        {
        }

        public DbSet<dotnet.tp3.GestaoDeLaboratorios.Models.Computador> Computador { get; set; } = default!;
    }
}
