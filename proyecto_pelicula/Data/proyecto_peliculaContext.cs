using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace proyecto_pelicula.Data
{
    public class proyecto_peliculaContext : DbContext
    {
        public proyecto_peliculaContext (DbContextOptions<proyecto_peliculaContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
