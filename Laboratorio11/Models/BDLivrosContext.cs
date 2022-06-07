using Microsoft.EntityFrameworkCore;

namespace Laboratorio11.Models; //verificar se é necessário

public class BDLivrosContext : DbContext
{
    //propriedade
    public DbSet<Autor> autor { get; set; }
    public DbSet<Livro> livro { get; set; }
    public DbSet<Emprestimo> emprestimo { get; set; }

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
    // verificar no BD se a tabela Autor seguiu modelo acima e o que aconteceu com as outras tabelas que não foram definidas aqui
}