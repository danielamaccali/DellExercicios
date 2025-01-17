﻿using System.Collections.Generic;


//1
List<string> listaStrings = new List<string>();
listaStrings.Add("Um");
listaStrings.Add("Hello");
listaStrings.Add("World");
Console.WriteLine(listaStrings[0]);
Console.WriteLine(listaStrings[1]);
Console.WriteLine(listaStrings[2]);
// listaStrings.Add(10); //teste inserindo tipo diferente declarado lista

//2
Console.WriteLine("SEgunda parte");
Queue<Object> q = new Queue<object>();
q.Enqueue(".Net Framework");
q.Enqueue(new Decimal(123.456));
q.Enqueue(654.321);
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());
Queue<int> minhaFila = new Queue<int>();
minhaFila.Enqueue(10);
minhaFila.Enqueue(200);
minhaFila.Enqueue(1000);
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());
Console.WriteLine(minhaFila.Dequeue());

//3
Console.WriteLine("Terceira parte");
Dictionary<int, string> paises = new Dictionary<int, string>();
paises[44] = "Reino Unido";
paises[33] = "França";
paises[55] = "Brasil";
Console.WriteLine("O código 55 é: {0}", paises[55]);
foreach(KeyValuePair<int, string> item in paises)
{
    int codigo = item.Key;
    string pais = item.Value;
    Console.WriteLine("Código {0} = {1}", codigo, pais);
}

//Exercícios

Console.WriteLine("Exercício 1");
foreach(KeyValuePair<int, string> item in paises)
{
    int codigo = item.Key;
    string pais = item.Value;
    Console.WriteLine($"Código {pais} = {codigo}");
}

Console.WriteLine("Exercício 2");
List<int> numerosReais = new List<int>();
numerosReais.Add(3);
numerosReais.Add(10);
numerosReais.Add(15);
numerosReais.Add(22);
numerosReais.Add(29);

var media = numerosReais.Sum() / numerosReais.Count();
int cont = 0;
//Quantidade de elementos acima da média.
foreach(var item in numerosReais)
{
    if(item > media)
    {
        cont++;
    }
}
Console.WriteLine($"Quantidade de elementos acima da média: {cont}");
//Lsita de números acima da média.
foreach(var item in numerosReais)
{
    if(item > media)
    {
        Console.WriteLine($"Número {item} acima da média.");
    }
}

