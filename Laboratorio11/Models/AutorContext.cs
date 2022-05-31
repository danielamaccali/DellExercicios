using Microsoft.EntityFrameworkCore;

public class AutorContext : DbContext
{
    public AutorContext():base("BDLivros") //verificar este erro
    {
    }

    public DbSet<Autor> Autor { get; set; }
}