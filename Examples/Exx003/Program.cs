// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int a;
Console.Write("Введите число - ");
int.TryParse(Console.ReadLine()!, out a);
if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
