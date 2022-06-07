


public interface ILivroRepository
{
    Task<IEnumerable<Livro>> ConsultarTodosAsync();
    Task<Livro> ConsultarAsync(int id);

}

/*
Repositório de livros:
• registrar um novo livro;
• consultar o banco de dados e retornar uma coleção com todos os livros;
• consultar o banco de dados e retornar uma coleção com todos os livros de um determinado autor cujo id
foi passado por parâmetro.

*/