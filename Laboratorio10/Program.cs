List<Pessoa> pessoas = new List<Pessoa>
{
    new Pessoa{Nome="Ana",DataNascimento=new DateTime(1980,3,14), Casada=true},
    new Pessoa{Nome="Paulo",DataNascimento=new DateTime(1978,10,23), Casada=true},
    new Pessoa{Nome="Maria",DataNascimento=new DateTime(2000,1,10), Casada=false},
    new Pessoa{Nome="Carlos",DataNascimento=new DateTime(1999,12,12), Casada=false}
};

var linq1 =
    from p in pessoas
    where p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1)
    select p;

foreach (var pessoa in linq1)
{
    Console.WriteLine(pessoa);
}

var linq2 = pessoas.Where(p => p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1));
foreach (var pessoa in linq2)
{
Console.WriteLine("\n Lambda: escrito de outra forma - mesmo resultado:");
Console.WriteLine(pessoa);
}

// Exercício 1. Construa uma consulta que retorne as pessoas agrupadas em casadas e solteiras e também o número de pessoas casadas e solteiras

Console.WriteLine("\n Exercício 1: pessoas agrupadas em casadas e solteiras e total por grupo. ");

var linq3 = 
    from p in pessoas
    group p by p.Casada into grupoStatus
    orderby grupoStatus.Key
    select grupoStatus;

foreach (var grupoStatus in linq3)
{
    Console.WriteLine($"Nome: {grupoStatus.Key}");
    foreach(var p in grupoStatus)
    {
        Console.WriteLine($"\t{p.Nome}");
    }
    Console.WriteLine($"Total: {grupoStatus.Count()}");
}
// Exercício 2. Construa uma consulta que retorne a pessoa mais velha.

Console.WriteLine("\nPessoa mais velha: ");
var linq4= pessoas.MinBy(p => p.DataNascimento); // byDescending seria apropriado aqui?
Console.WriteLine($"{linq4.Nome} - {linq4.DataNascimento.ToShortDateString()}");


// TESTES
//var testeLambda = pessoas.OrderByDescending(p => p.DataNascimento >= new DateTime()).ToList();
//var testeLambda = pessoas.Where(p => p.DataNascimento >= new DateTime());
//foreach(var nasc in testeLambda)
/* {
    Console.WriteLine($"Nome: {nasc.Nome} - {nasc.DataNascimento}");
} */

// Exercício 3. Construa uma consulta que retorne a pessoa solteira mais nova.
var linq5 = pessoas.Where(p => p.Casada == false).MaxBy(p =>p.DataNascimento);
Console.WriteLine($"\nPessoas solteira mais nova: {linq5.Nome} - {linq5.DataNascimento.ToShortDateString()}");

// var linq2 = pessoas.Where(p => p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1));

/* TESTES
var linq5 = pessoas.Where(p => p.Casada = false && p.DataNascimento >= new DateTime());
foreach(var item in pessoas)
{
    Console.WriteLine($"Solteiras - ordenada por mais jovem: {item.Nome}, {item.DataNascimento}");
}
*/