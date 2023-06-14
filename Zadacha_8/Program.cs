// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные 
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N ");
int N = int.Parse(Console.ReadLine()!);
int N1 = 2;
while (N1 <= N)
{
    Console.WriteLine($"{N1}"); 
    N1 += 2;
}

