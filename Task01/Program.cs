// 1. на вход принимает два числа
// 2. выдаёт, какое число большее, а какое меньшее.
// Например: a = 5; b = 7 -> max = 7; a = 2 b = 10 -> max = 10; a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое целое число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int b = Convert.ToInt32 (Console.ReadLine());


if (b > a) 
{
Console.Write("Max= ");
Console.WriteLine(b);

Console.Write("Min= ");
Console.WriteLine(a);
}

else
{
Console.Write("Max= ");
Console.WriteLine(a);

Console.Write("Min= ");
Console.WriteLine(b);
}