﻿// Напишите программу, которая на вход 
// принимиает два числа и выдает, какое 
// число большее, а какое меньшее.

// a = 5 b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9 b = -3 -> max -3

Console.Write("Введите первое число"  );
int numberA = int.Parse( Console.ReadLine()!);

Console.Write("Введите второе число"  );
int numberB = int.Parse( Console.ReadLine()!);

if(numberA < numberB)
{
    Console.WriteLine($"Максимальное число: {numberB}");
    Console.WriteLine($"Минимальное число: {numberA}");
}

