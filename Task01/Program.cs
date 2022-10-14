// 1. на вход принимает два числа
// 2. выдаёт, какое число большее, а какое меньшее.
// Например: a = 5; b = 7 -> max = 7; a = 2 b = 10 -> max = 10; a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое целое число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите третье целое число: ");
int c = Convert.ToInt32 (Console.ReadLine());

int max = a;
int min = a;

if (b > max) max = b;
if (c > max) max = c;

if (b < min) min = b;
if (c < min) min = c;

Console.Write("Максимальное из трех чисел: ");
Console.WriteLine(max);

Console.Write("Минимальное из трех чисел: ");
Console.WriteLine(min);