public interface IEmprestimoRepository
{
    Task<IEnumerable<Emprestimo>> ConsultarTodosAsync();

    Task<Emprestimo> ConsultarAsync(int id);
    
}