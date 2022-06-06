using Laboratorio11.Models;
using Microsoft.EntityFrameworkCore;

public class EmprestimoRepository : IEmprestimoRepository
{
    
    private readonly BDLivrosContext _contexto;

    public EmprestimoRepository(BDLivrosContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<IEnumerable<Emprestimo>> ConsultarTodosAsync()
    {
        return await _contexto.emprestimo.ToListAsync();
    }

    public async Task<Emprestimo> ConsultarAsync(int id)
    {
        return await _contexto.emprestimo.FindAsync(id);
    }

}