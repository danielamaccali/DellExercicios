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
Console.WriteLine("\n Linq escrito de outra forma - mesmo resultado:");
Console.WriteLine(pessoa);
}

// Exercício 1. Construa uma consulta que retorne as pessoas agrupadas em casadas e solteiras e também o número de pessoas casadas e solteiras

Console.WriteLine("Exercício 1");

var linq3 = 
    from p in pessoas
    where p.Casada = true
    select p;

foreach (var pessoa in linq3)
{
    Console.WriteLine(pessoa);
}
// Exercício 2. Construa uma consulta que retorne a pessoa mais velha.

Console.WriteLine("Pessoa mais velha: ");
var linq4 = pessoas.Where(p => p.DataNascimento); //implementar filtro
foreach(var pessoa in linq4)
{
    Console.WriteLine(pessoa);
}

// Exercício 3. Construa uma consulta que retorne a pessoa solteira mais nova.

