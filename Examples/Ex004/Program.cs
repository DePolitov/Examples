// See https://aka.ms/new-console-template for more information
int a,b;
Console.Write("Введите число 1 - ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите число 2 - ");
int.TryParse(Console.ReadLine()!, out b);
if (a/b==b)
{
    Console.WriteLine ("Число 1 является квадратом 2го");
}
else{
    if (b/a==a)
    {
      Console.WriteLine ("Число 2 является квадратом 1го");  
    }
    else{
        Console.WriteLine ("нет");
    }

}