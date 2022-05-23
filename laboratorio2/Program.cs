// Laboratório 2 - Arrays

int[] array = new int[5] {10, 20, 30, 40, 50};
int i;
for(i = 0; i < 5; i++)
{
    Console.WriteLine("Índice = " + i + " & Valor = " + array[i]);
}

Console.WriteLine("----------------------");

string[] str = new string[3];
int iStr;
str[0] = "Um";
str[1] = "Dois";
str[2] = "Três";
for(iStr = 0; iStr <3; iStr++)
{
    Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
}

Console.WriteLine("----------------------");

DateTime[] dt = new DateTime[2];
int iDate;
dt[0] = new DateTime(2002, 5, 1);
dt[1] = new DateTime(2002, 6, 1);
for(iDate=0; iDate<2; iDate++)
{
    Console.WriteLine("Índice = " + iDate + " & Data = " + dt[iDate].ToShortDateString());
}

Console.WriteLine("----------------------");

iDate = 0;

foreach(DateTime item in dt)
{
    Console.WriteLine("Índice = " + iDate  + " & Data = " + item.ToShortDateString());
    iDate++;
}

// Exercício 1:

int[] arrayUm = new int[100];
int[] arrayDois = new int[100];
int numArray1 = 1;
for(i=0; i<100; i++)
{
    arrayUm[i] = numArray1;
    numArray1++;
}

arrayUm.ToList().ForEach(Console.WriteLine);

Array.Copy(arrayUm, arrayDois, arrayUm.Length);

Console.WriteLine("Array 2");
arrayDois.ToList().ForEach(Console.WriteLine);

// Exercício 2

int[,] matriz = new int[5,5]{ {10, 20, 30, 40, 50}, {11, 22, 33, 44, 55}, {10, 20, 30, 40, 50}, {11, 22, 33, 44, 55}, {1, 2, 3, 4, 5}};

int soma = 0; //soma das colunas

for(i=0; i<matriz.Length; i++) //linha
{
    for(var j=0; j<matriz.Length; j++) //coluna
    {
        soma =+ matriz[i, j];
    }
}

Console.WriteLine($"soma = {soma}");