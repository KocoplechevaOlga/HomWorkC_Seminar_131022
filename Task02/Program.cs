// 1. принимает на вход три числа
// 2. выдаёт максимальное из этих чисел.
// Например: 2, 3, 7 -> 7; 44 5 78 -> 78; 22 3 9 -> 22
Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите Третье целое число");
int c = Convert.ToInt32 (Console.ReadLine());

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное число: ");
Console.WriteLine(max);