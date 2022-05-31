using Microsoft.EntityFrameworkCore;

public class AutorContext : DbContext
{
    public AutorContext():base("BDLivros")
    {
    }

    public DbSet<Autor> Autor { get; set; }
}