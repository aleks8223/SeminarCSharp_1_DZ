// Напишите программу, которая принимает на
// вход три числа и выдает максимальное из
// этих чисел.

// Пример
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 39, 9 -> 22

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine()!);

int max = numberA;

if(max < numberB)
{
    max = numberB;
}
else
{
    max = numberA;
}
if(max < numberC)
{
    max = numberC;
}
else
{
    max = numberA;
}
Console.WriteLine($"Максимальное число из чисел: {max}");
