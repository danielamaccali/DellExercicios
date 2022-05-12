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
Console.WriteLine(strTerceira.Substring(0, 5));

DateTime dt = new DateTime(2022, 05, 02);
string strQuinta = dt.ToString();
Console.WriteLine(strQuinta);

//Exercícios

float fl = float.MaxValue;
double db = double.MaxValue;
decimal dc = decimal.MaxValue;
Console.WriteLine($"O tamanho máximo de: \n float: {fl} \n double: {db} \n decimal: {dc} \n ");