using Microsoft.EntityFrameworkCore;

namespace Laboratorio11.Models; //verificar se é necessário

public class BDLivrosContext : DbContext
{
    public DbSet<Autor> Autor { get; set; }

    public BDLivrosContext() //construtor sem parâmetros
    {
    }

    public BDLivrosContext(DbContextOptions<BDLivrosContext> options)
    {
        //implementar
    }


}