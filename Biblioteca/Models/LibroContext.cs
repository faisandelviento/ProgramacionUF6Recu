using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models;

public class LibroContext : DbContext
{
    public LibroContext(DbContextOptions<LibroContext> options)
        : base(options)
    {
    }

    public DbSet<Libro> Libro { get; set; } = null!;
}