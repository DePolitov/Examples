int a;
int b;
int c;
int max;
Console.Write ("Введите первое число -");
int.TryParse(Console.ReadLine()!, out a);
Console.Write ("Введите второе число -");
int.TryParse(Console.Readline()!, out b);
Console.Write ("Введите третье число -");
int.TryParse(Console.Readline()!, out c);
if (b>a)
{
    int max=b;
}
if (c>a)
{
   int max=c;
}
else {int max=a;}
Console.Write($"Максимальное число - {max}\n");