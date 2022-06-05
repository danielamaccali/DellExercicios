using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AutorController : ControllerBase
{
    private readonly IAutorRepository _autorRepository;

    public AutorController(IAutorRepository autorRepository) //recebe injeção de dependência
    {
        _autorRepository = autorRepository;
    }


    [HttpGet]
    [Route("ListarTodos")]
    public async Task<IActionResult> ListarTodos()
    {
        return Ok(await _autorRepository.ConsultarTodosAsync());
    }
}