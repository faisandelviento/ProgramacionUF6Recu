namespace Biblioteca.Models;

public class Libro
{
    public long Id { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
    public int Paginas { get; set; }
}