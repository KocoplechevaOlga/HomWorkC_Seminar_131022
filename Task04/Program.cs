// 1. на вход принимает число (N)
// 2. на выходе показывает все чётные числа от 1 до N
// Например: 5 -> 2, 4; 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.WriteLine("Результат:");

while(count <= number)
{
    if (count % 2 ==0)
    {
        Console.WriteLine(count);
        count = count+1;
    }
    else
    {
        count = count+1;
    }
}
