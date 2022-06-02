using Microsoft.EntityFrameworkCore;

namespace Laboratorio11.Models; //verificar se é necessário

public class BDLivrosContext : DbContext
{
    //parâmetros
    public DbSet<Autor> Autor { get; set; }

    //Construtores
    public BDLivrosContext() //construtor sem parâmetros
    {
    }

    public BDLivrosContext(DbContextOptions<BDLivrosContext> options)
    :base(options)
    {
    }

    //
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>
        (entityBuilder =>   {entityBuilder.Property(e => e.id).HasMaxLength(3);
                            entityBuilder.Property(e => e.primeiroNome).HasMaxLength(30);
                            entityBuilder.Property(e => e.ultimoNome).HasMaxLength(30);}
        );

        
    }

}