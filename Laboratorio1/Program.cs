byte b;
b = byte.MaxValue;
Console.WriteLine($"Valor máximo de byte: {b}");

int i;
i = int.MaxValue;
Console.WriteLine($"Valor máximo de inteiro: {i}");

long l;
l = long.MaxValue;
Console.WriteLine($"Valor máximo de long: {l}");

string strPrimeira = "Alo ";
string strSegunda = "Mundo";
string strTerceira = strPrimeira + strSegunda;
int cchTamanho = strTerceira.Length;
string strQuarta = "Tamanho = " + cchTamanho.ToString();
Console.WriteLine(strQuarta);