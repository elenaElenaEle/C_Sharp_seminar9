﻿// 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumDig(int num)
{
    if (num == 0) return 0;
    return SumDig(num / 10) + num % 10;
}

Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine(SumDig(m));