public interface IAutorRepository
{

    // Interface definindo Task

    Task<IEnumerable<Autor>> ConsultarTodosAsync();
    Task<Autor> ConsultarAsync(int id);
}

/*Repositório de autores:
• consultar o banco de dados e retornar uma coleção com todos os autores cujo último nome seja igual ao
parâmetro informado;
• registrar um novo autor;
• alterar o registro de um autor no banco de dados.
*/