using H05.RateAMovie.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace H05.RateAMovie.Data
{
    public class MovieContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options): base(options)
        {

        }

    }
}
