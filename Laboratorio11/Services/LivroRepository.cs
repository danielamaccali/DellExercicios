
using Laboratorio11.Models;
using Microsoft.EntityFrameworkCore;


public class LivroRepository : ILivroRepository
{

    private readonly BDLivrosContext _contexto;

    public LivroRepository(BDLivrosContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<IEnumerable<Livro>> ConsultarTodosAsync()
    {
        return await _contexto.livro.ToListAsync();
    }

    public async Task<Livro> ConsultarAsync(int id)
    {
        var livro = await _contexto.livro.FindAsync(id);
        return livro;
    }

}
