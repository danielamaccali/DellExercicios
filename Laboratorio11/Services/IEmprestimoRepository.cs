public interface IEmprestimoRepository
{
    Task<IEnumerable<Emprestimo>> ConsultarTodosAsync();

    Task<Emprestimo> ConsultarAsync(int id);
    
}

/*
Repositório de empréstimos:
• registrar um novo empréstimo;
• alterar o registro de um empréstimo;
• consultar o banco de dados e retornar o registro de empréstimo em aberto de um determinado livro cujo
id foi passado por parâmetro.
*/