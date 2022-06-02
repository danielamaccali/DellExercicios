public interface IAutorRepositoryEF
{

    // Interface definindo Task

    Task<IEnumerable<Autor>> ConsultarTodosAsync();
    Task<Autor> ConsultarAsync(int id);
}