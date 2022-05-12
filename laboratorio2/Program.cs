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