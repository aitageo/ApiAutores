using ApiAutores.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ApiAutores
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet <Autor>  Autores { get; set; }
    }

}
