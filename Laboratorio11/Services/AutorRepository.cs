
using Laboratorio11.Models;
using Microsoft.EntityFrameworkCore;

public class AutorRepository : IAutorRepositoryEF
{
    //implementação obrigatória da Interface IAutorRepository

    private readonly BDLivrosContext _contexto;

    public AutorRepository(BDLivrosContext contexto)
    {
        _contexto =contexto;
    }

    public async Task<IEnumerable<Autor>> ConsultarTodosAsync()
    {
        return await _contexto.Autor.ToListAsync();
    }

    async Task<Autor> ConsultarAsync(int id) //seguindo exemplo do professor
    {
        var autor = await _contexto.Autor.FindAsync(id);
        return autor;

    }

    Task<Autor> IAutorRepositoryEF.ConsultarAsync(int id) // auto gerado, pois estava acusando que não estava implementando - verificar
    {
        throw new NotImplementedException();
    }
}