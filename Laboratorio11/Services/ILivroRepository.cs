

namespace Laboratorio11.Services
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> ConsultarTodosAsync();
        Task<Livro> ConsultarAsync(int id);

    }
}