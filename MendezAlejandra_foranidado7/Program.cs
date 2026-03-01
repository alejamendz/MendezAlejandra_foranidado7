// See https://aka.ms/new-console-template for more information
Console.WriteLine("Mostrar las combinaciones posibles de números del 1 al 3");

for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine(i + "-" + j);
    }
}