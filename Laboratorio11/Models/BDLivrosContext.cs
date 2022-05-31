using Microsoft.EntityFrameworkCore;

namespace Laboratorio11.Models; //verificar se é necessário

public class BDLivrosContext : DbContext
{
    public BDLivrosContext() //construtor sem parâmetros
    {
    }

    public BDLivrosContext(DbContextOptions<BDLivrosContext> options)
    {
        //implementar
    }

}